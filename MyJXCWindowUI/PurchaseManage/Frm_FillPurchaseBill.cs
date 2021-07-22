using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuQiJing.Model;
using LuQiJing.BLL;

namespace LuQiJing.MyJXCWindowUI.PurchaseManage
{
    public partial class Frm_FillPurchaseBill : BaseForm.BasePurChaseBillForm
    {   
        private Operation op;
        private static PurchaseDetail detail_Add;
        private PurchaseBillBLL purBLL;
        public static PurchaseDetail Detail_Add
        {
            set { Frm_FillPurchaseBill.detail_Add = value; }
        }
        public Frm_FillPurchaseBill()
        {
            InitializeComponent();
            purBLL = new PurchaseBillBLL();
            op = Operation.None;
        }

        private void btnNewInsert_Click(object sender, EventArgs e)
        {
            op = Operation.Insert;

            //初始化订单及订单明细
            pur = new PurchaseBill();
            detailList = new List<PurchaseDetail>();

            //（1）	命令按钮的控制（7个按钮）
            btnNewInsert.Enabled = btnUpdate.Enabled = btnRevoke.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = btnAddInformation.Enabled = btnDeleteInformation.Enabled = true;

            //（2）	订单信息控件的控制（6个控件）
            dtpIndentDate.Enabled = true;
            cbSupplier.Enabled = true; ;
            txtStorageDate.Enabled = false;
            txtState.Enabled = false;
            txtNote.Enabled = true;


            //（3）	列表框的控制（1个控制）
            lstPurchaseIDList.Enabled = false;

            //（4）	DataGridView列的控制（2列）
            dgDetailInfo.Columns[3].ReadOnly = false;
            dgDetailInfo.Columns[4].ReadOnly = false;

            //（5）	查询控件的控制（分组框的控制）
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnQuery.Enabled = false;
            cbQueryValue.Enabled = false;
            cbQueryCondition.Enabled = false;

            //控件默认值控制
            dtpIndentDate.Value = DateTime.Now;
            cbSupplier.SelectedIndex = 0;
            txtStorageDate.Text = "";
            txtState.Text = ("执行（未审核）");
            txtNote.Text = "";
            dgDetailInfo.DataSource = null;
            lstPurchaseIDList.SelectedIndex = -1;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pur == null)
            {
                MessageBox.Show("请选择一笔订单！");
                return;
            }
            if (pur.OnProcess == 1 || pur.OnProcess == 2)
            {
                MessageBox.Show("该订单已撤销或修改，不能修改！");
                return;
            }
            if (pur.Examiner != "")
            {
                MessageBox.Show("该订单已审核，不能修改！");
                return;
            }

            op = Operation.Update;
            //（1）	命令按钮的控制（7个按钮）
            btnNewInsert.Enabled = btnUpdate.Enabled = btnRevoke.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = btnAddInformation.Enabled = btnDeleteInformation.Enabled = true;

            //（2）	订单信息控件的控制（6个控件）
            dtpIndentDate.Enabled = false;
            cbSupplier.Enabled = true; ;
            txtPurchaseID.Enabled = txtStorageDate.Enabled = txtState.Enabled = false;
            txtNote.Enabled = true;


            //（3）	列表框的控制（1个控制）
            lstPurchaseIDList.Enabled = false;

            //（4）	DataGridView列的控制（2列）
            dgDetailInfo.Columns[3].ReadOnly = false;
            dgDetailInfo.Columns[4].ReadOnly = false;

            //（5）	查询控件的控制（分组框的控制）
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnQuery.Enabled = false;
            cbQueryValue.Enabled = false;
            cbQueryCondition.Enabled = false;
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            if (pur == null)
            {
                MessageBox.Show("请选择一笔订单！");
                return;
            }
            op = Operation.Delete;
            //（1）	命令按钮的控制（7个按钮）
            btnNewInsert.Enabled = btnUpdate.Enabled = btnRevoke.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
            btnAddInformation.Enabled = btnDeleteInformation.Enabled = false;

            //（2）	订单信息控件的控制（6个控件）
            dtpIndentDate.Enabled = false;
            cbSupplier.Enabled = false; ;
            txtPurchaseID.Enabled = txtStorageDate.Enabled = txtState.Enabled = false;
            txtNote.Enabled = true;


            //（3）	列表框的控制（1个控制）
            lstPurchaseIDList.Enabled = false;

            //（4）	DataGridView列的控制（2列）
            dgDetailInfo.Columns[3].ReadOnly = true;
            dgDetailInfo.Columns[4].ReadOnly = true;

            //（5）	查询控件的控制（分组框的控制）
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnQuery.Enabled = false;
            cbQueryValue.Enabled = false;
            cbQueryCondition.Enabled = false;
        }

        private void Reoste()
        {
            op = Operation.None;
            //（1）	命令按钮的控制（7个按钮）
            btnNewInsert.Enabled = btnUpdate.Enabled = btnRevoke.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = btnAddInformation.Enabled = btnDeleteInformation.Enabled = false;

            //（2）	订单信息控件的控制（6个控件）
            dtpIndentDate.Enabled = false;
            cbSupplier.Enabled = false;
            txtPurchaseID.Enabled = txtStorageDate.Enabled = txtState.Enabled = txtNote.Enabled = false;

            //（3）	列表框的控制（1个控制）
            lstPurchaseIDList.Enabled = true;

            //（4）	DataGridView列的控制（2列）
            dgDetailInfo.Columns[3].ReadOnly = true;
            dgDetailInfo.Columns[4].ReadOnly = true;
            dgDetailInfo.DataSource = null;

            //（5）	查询控件的控制（分组框的控制）
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnQuery.Enabled = true;
            cbQueryValue.Enabled = true;
            cbQueryCondition.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Reoste();

        }

        private void btnDeleteInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (detail_delete == null)
                {
                    MessageBox.Show("请选择要删除的一条明细信息！");
                    return;
                }
                DialogResult result = MessageBox.Show("您确实要删除这条明细信息吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //移除一行记录
                    detailList.Remove(detail_delete);

                    //遍历明细编号进行编号
                    int i = 1;
                    foreach (PurchaseDetail detail in detailList)
                    {
                        detail.PurchaseDetailID = i++;
                    }

                    //重新绑定明细信息
                    BindData();
                }
            }
            catch
            {


            }
        }
        private void BindData()
        {
            dgDetailInfo.DataSource = null;
            dgDetailInfo.DataSource = detailList;

            //取消单元格反蓝
            if (dgDetailInfo.CurrentCell != null)
            {
                dgDetailInfo.CurrentCell.Selected = false;
            }
        }

        private void btnAddInformation_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ChooseProduct frm_Product = new Frm_ChooseProduct();
                frm_Product.ShowDialog();

                if (detail_Add != null)
                {
                    foreach (PurchaseDetail detail in detailList)
                    {
                        if (detail.ProductID == detail_Add.ProductID)
                        {
                            MessageBox.Show("该产品已存在！");
                            return;
                        }
                    }
                    detail_Add.PurchaseID = txtPurchaseID.Text.Trim();
                    detail_Add.PurchaseDetailID = detailList.Count + 1;
                    detailList.Add(detail_Add);

                    BindData();
                }
            }
            catch
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (op == Operation.Insert || op == Operation.Update)
                {
                    if (detailList.Count == 0)
                    {
                        MessageBox.Show("没有订单明细信息，请增加订单明细信息！");
                        return;
                    }
                    foreach (PurchaseDetail d in detailList)
                    {
                        if (d.PurchasePrice == 0 || d.Quantity == 0)
                        {
                            MessageBox.Show("购入单价和数量不能为0！");
                            return;
                        }
                    }

                }
                if (op == Operation.Insert)
                {
                    pur.PurchaseID = txtPurchaseID.Text;
                    pur.SupplierID = cbSupplier.SelectedValue.ToString();
                    pur.PurchaseDate = dtpIndentDate.Value;
                    pur.StockDate = DateTime.MinValue;
                    pur.Clerk = EmployeeID;
                    pur.Examiner = "";
                    pur.Custodian = "";
                    pur.OnProcess = 0;
                    pur.Memo = txtNote.Text.Trim();
                    pur.DetailList = detailList;

                    if (purBLL.Insert(pur))
                    {
                        Reoste();
                        MessageBox.Show("新增订单成功！");
                    }
                    else
                    {
                        MessageBox.Show("新增订单失败！");
                    }
                    pur = null;

                }
                else if (op == Operation.Update)
                {
                    pur.SupplierID = cbSupplier.SelectedValue.ToString();
                    pur.Memo = txtNote.Text.Trim();
                    pur.DetailList = detailList;
                    if (purBLL.Update(pur))
                    {
                        Reoste();
                        MessageBox.Show("订单修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("订单修改失败！");
                    }

                }
                else
                {
                    pur.OnProcess = 1;
                    pur.Memo = txtNote.Text.ToString().Trim();
                    if (purBLL.UpdateDetailOnly(pur))
                    {
                        Reoste();
                        MessageBox.Show("订单撤销成功！");
                        txtState.Text = "撤销";
                    }
                    else
                    {
                        MessageBox.Show("订单撤销失败！");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dtpIndentDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (op == Operation.Insert)
                {
                    txtPurchaseID.Text = purBLL.CreatePurchaseID(dtpIndentDate.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtPurchaseID_TextChanged(object sender, EventArgs e)
        {

            if (op == Operation.Insert && detailList !=null)
            {
                foreach (PurchaseDetail d in detailList)
                {
                    d.PurchaseID = txtPurchaseID.Text;
                }
                BindData();
            }   
        }
    }
}
