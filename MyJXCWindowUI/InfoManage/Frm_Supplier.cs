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

namespace LuQiJing.MyJXCWindowUI.InfoManage
{
    public partial class Frm_Supplier : BaseForm.BaseInfoForm
    {
        private SupplierBLL suBLL;
        private List<Supplier> list;
        private Supplier su;
        private int currentRowIndex;
        public Frm_Supplier()
        {
            InitializeComponent();
            suBLL = new SupplierBLL();
            su = new Supplier();
        }

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            try
            {
                GetSupplierInfo();
                dgSuoplierInfo.CurrentCell.Selected = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetSupplierInfo()
        {
            try
            {
                list = suBLL.GetList();
                dgSuoplierInfo.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgSuoplierInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSuoplierInfo.CurrentRow.Selected = true;
            currentRowIndex = dgSuoplierInfo.CurrentRow.Index;
            su = list[currentRowIndex];
            if (op == Operation.Update || op == Operation.Delete)
            {
                SetTextBox();
            }
        }
        private void SetTextBox()
        {
            txtSupplierID.Text = su.SupID;
            txtSupplierName.Text = su.SupName;
            txtSpellingCode.Text = su.SpeCode;
            txtAddress.Text = su.Ads;
            txtZipCode.Text = su.ZiCode;
            txtTel.Text = su.Tel;
            txtFax.Text = su.Fax;
            txtBankName.Text = su.BkName;
            txtBankAccount.Text = su.BkCount;
            txtContacter.Text = su.Coter;
            txtEmail.Text = su.Email;
        }

        private void btnNewInsert_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbInfo.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                    ((TextBox)c).Clear();
                }
            }
            txtSpellingCode.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbInfo.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
            }
            txtSupplierID.Enabled = false;
            txtSpellingCode.Enabled = false;
            if (su != null)
            {
                SetTextBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbInfo.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                }
            }
            if (su != null)
            {
                SetTextBox();
            }
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Common.HZToSpell(txtSupplierName.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in gbInfo.Controls)
                {
                    if (c is TextBox && c.Text == "")
                    {
                        MessageBox.Show("请输入所有内容！");
                        ((TextBox)c).Focus();
                        return;
                    }
                }
                if (op == Operation.Insert)
                {
                    GetTextBox();

                    if (suBLL.Insert(su))
                    {
                        GetSupplierInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].SupID == su.SupID)
                            {
                                break;
                            }
                        }
                        dgSuoplierInfo.Rows[i].Selected = true;
                        dgSuoplierInfo.CurrentCell = dgSuoplierInfo.Rows[i].Cells[0];
                        MessageBox.Show("新增记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("新增记录失败！");
                    }

                }
                else if (op == Operation.Update)
                {
                    GetTextBox();
                    if (suBLL.Update(su))
                    {
                        GetSupplierInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].SupID == su.SupID)
                            {
                                break;
                            }
                        }
                        dgSuoplierInfo.Rows[i].Selected = true;
                        dgSuoplierInfo.CurrentCell = dgSuoplierInfo.Rows[i].Cells[0];
                        MessageBox.Show("修改记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改记录失败！");
                    }

                }
                else if (op == Operation.Delete)
                {
                    if (suBLL.Delete(su))
                    {

                        if (list.Count != 0)
                        {
                            GetSupplierInfo();
                            dgSuoplierInfo.CurrentRow.Selected = false;
                            MessageBox.Show("删除记录成功！");
                        }
                        su = null;
                    }
                    else
                    {
                        MessageBox.Show("删除记录失败！");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void GetTextBox()
        {
            string supID = txtSupplierID.Text.Trim();
            string supName = txtSupplierName.Text.Trim();
            string speCode = txtSpellingCode.Text.Trim();
            string ads = txtAddress.Text.Trim();
            string ziCode = txtZipCode.Text.Trim();
            string tel = txtTel.Text.Trim();
            string fax = txtFax.Text.Trim();
            string bkName = txtBankName.Text.Trim();
            string bkCount = txtBankAccount.Text.Trim();
            string coter = txtContacter.Text.Trim();
            string emaill = txtEmail.Text.Trim();
            su = new Supplier(supID, supName, speCode, ads, ziCode, tel, fax, bkName, bkCount, coter, emaill);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                su.SupID = qID;
                su.SupName = qName;
                list = suBLL.GetSupplierBySupplierIDAndSupplierName(su);
                if (list.Count == 0)
                {
                    MessageBox.Show("没有您所要查找的记录！");
                    return;
                }
                else
                {
                    dgSuoplierInfo.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
