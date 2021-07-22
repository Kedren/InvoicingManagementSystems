using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuQiJing.BLL;
using LuQiJing.Model;


namespace LuQiJing.MyJXCWindowUI.BaseForm
{
    public partial class BasePurChaseBillForm : Form
    {
        private PurchaseBillBLL purBLL;
        private List<string> list;

        private string employeeID = "001";

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        protected PurchaseBill pur;
        protected List<PurchaseDetail> detailList;
        protected PurchaseDetail detail_delete;
        public BasePurChaseBillForm()
        {
            InitializeComponent();
            purBLL = new PurchaseBillBLL();

        }

        private void cbQueryCondition_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (cbQueryCondition.SelectedIndex >= 0 && cbQueryCondition.SelectedIndex <= 3)
            {
                cbQueryValue.DropDownStyle = ComboBoxStyle.Simple;
                cbQueryValue.Enabled = true;
                cbQueryValue.Text = "";
                dtpStartDate.Enabled = dtpEndDate.Enabled = false;
                ClearPre();
                if (cbQueryCondition.SelectedIndex == 3)
                {
                    ClearPre();
                    cbQueryValue.Enabled = true;
                    cbQueryValue.SelectedIndex = 0;
                    cbQueryValue.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            else if (cbQueryCondition.SelectedIndex == 4)
            {
                ClearPre();
                cbQueryValue.DropDownStyle = ComboBoxStyle.Simple;
                cbQueryValue.Enabled = false;
                cbQueryValue.Text = "";
                dtpStartDate.Enabled = dtpEndDate.Enabled = true;
            }

        }

        private void ClearPre()
        {
            lstPurchaseIDList.DataSource = null;
            txtPurchaseID.Clear();
            txtStorageDate.Clear();
            txtState.Clear();
            txtNote.Clear();
            txtTotal.Clear();
            dgDetailInfo.DataSource = null;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbQueryCondition.SelectedIndex >= 0 && cbQueryCondition.SelectedIndex <= 2)
                {
                    string searchValue = cbQueryValue.Text.Trim();
                    if (searchValue == "")
                    {
                        lstPurchaseIDList.DataSource = null;
                        MessageBox.Show("请输入查询的值！");
                        cbQueryValue.Focus();
                        return;
                    }
                    if (cbQueryCondition.SelectedIndex == 0)
                    {
                        list = purBLL.FindPurchaseIDByPurchaseID(searchValue);
                    }
                    else if (cbQueryCondition.SelectedIndex == 1)
                    {
                        list = purBLL.FindPurchaseIDByClerk(searchValue);
                    }
                    else if (cbQueryCondition.SelectedIndex == 2)
                    {
                        list = purBLL.FindPurchaseIDByExaminer(searchValue);
                    }
                }
                else if (cbQueryCondition.SelectedIndex == 3)
                {
                    int state;
                    if (cbQueryValue.SelectedIndex == 0)
                    {
                        state = 0;
                    }
                    else if (cbQueryValue.SelectedIndex == 1)
                    {
                        state = 1;
                    }
                    else
                    {
                        state = 2;
                    }
                    list = purBLL.FindPurchaseIDByOnProcess(state);

                }
                else if (cbQueryCondition.SelectedIndex == 4)
                {
                    DateTime startDate = dtpStartDate.Value.Date;
                    DateTime endDate = dtpEndDate.Value.Date;
                    if (startDate > endDate)
                    {
                        lstPurchaseIDList.DataSource = null;
                        MessageBox.Show("开始日期不能大于结束日期！");
                        return;
                    }
                    list = purBLL.FindPurchaseIDByPurchaseDate(startDate, endDate);
                }
                if (list.Count == 0)
                {
                    lstPurchaseIDList.DataSource = null;
                    MessageBox.Show("没有您所要查找的记录！");
                }
                lstPurchaseIDList.DataSource = list;
                lstPurchaseIDList.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BasePurChaseBillForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbQueryCondition.SelectedIndex = 0;
                dgDetailInfo.AutoGenerateColumns = false;
                cbSupplier.DataSource = new SupplierBLL().GetList();
                cbSupplier.ValueMember = "SupID";
                cbSupplier.DisplayMember = "SupName";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void lstPurchaseIDList_Click(object sender, EventArgs e)
        {
            try
            {
                pur = purBLL.FindByID(lstPurchaseIDList.SelectedItem.ToString());
                txtPurchaseID.Text = pur.PurchaseID;

                cbSupplier.SelectedValue = pur.SupplierID;
                if (pur.StockDate == DateTime.MinValue)
                {
                    txtStorageDate.Text = "";
                }
                else
                {
                    txtStorageDate.Text = pur.StockDate.ToLongDateString();
                }
                if (pur.OnProcess == 0)
                {
                    if (pur.Examiner == "")
                    {
                        txtState.Text = "执行(未审核)";
                    }
                    else
                    {
                        txtState.Text = "执行(已审核)";
                    }

                }
                else if (pur.OnProcess == 1)
                {
                    txtState.Text = "撤销";
                }
                else
                {
                    txtState.Text = "完成";
                }
                txtNote.Text = pur.Memo;
                detailList = pur.DetailList;
                if (detailList.Count == 0)
                {
                    dgDetailInfo.DataSource = null;
                }
                else
                {
                    dgDetailInfo.DataSource = detailList;
                    dgDetailInfo.CurrentCell.Selected = false;
                }            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void dgDetailInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    if (e.Value.ToString().Trim() != "")
                    {
                        e.Value = new ProductBLL().FindByID(e.Value.ToString().Trim()).ProductName;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgDetailInfo_CurrentCellChanged(object sender, EventArgs e)
        {
            decimal allProce = 0;
            foreach (PurchaseDetail detail in detailList)
            {
                allProce += detail.Account;
            }
            txtTotal.Text = allProce.ToString();
        }

        private void dgDetailInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgDetailInfo.CurrentRow.Selected = true;
                detail_delete = detailList[e.RowIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);          
            }
          
        }

        private void dgDetailInfo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgDetailInfo.Rows[e.RowIndex].IsNewRow) return;
            decimal dci;
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                if (e.FormattedValue != null && e.FormattedValue.ToString().Length > 0)
                {
                    if (!decimal.TryParse(e.FormattedValue.ToString(), out dci) || dci < 0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("请输入数字或小数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
