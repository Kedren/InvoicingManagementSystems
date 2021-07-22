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
    public partial class Frm_Customer : BaseForm.BaseInfoForm
    {
        private CustomerBLL cuBLL;
        private List<Customer> list;
        private Customer cu;
        private int currentRowIndex;
        public Frm_Customer()
        {
            InitializeComponent();
            cuBLL = new CustomerBLL();
            cu = new Customer();
        }

        private void dgProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgCustomerInfo.CurrentRow.Selected = true;
            currentRowIndex = dgCustomerInfo.CurrentRow.Index;
            cu = list[currentRowIndex];
            if (op == Operation.Update || op == Operation.Delete)
            {

                SetTextBox();

            }

        }

        private void SetTextBox()
        {
            txtCustomerID.Text = cu.CustomerID;
            txtCustomerName.Text = cu.CustomerName;
            txtSpellingCode.Text = cu.SpellingCode;
            txtAddress.Text = cu.Address;
            txtZipCode.Text = cu.ZipCode;
            txtTel.Text = cu.Tel;
            txtFax.Text = cu.Fax;
            txtBankName.Text = cu.BankName;
            txtBankAccount.Text = cu.BankAccount;
            txtContacter.Text = cu.Contacter;
            txtEmail.Text = cu.Email;
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            try
            {
                GetCustomerInfo();
                dgCustomerInfo.CurrentCell.Selected = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCustomerInfo()
        {
            try
            {
                list = cuBLL.GetList();
                dgCustomerInfo.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
            txtSpellingCode.Enabled = false;
            txtCustomerID.Enabled = false;
            if (cu != null)
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
            if (cu != null)
            {
                SetTextBox();
            }
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
                    if (cuBLL.Insert(cu))
                    {
                        GetCustomerInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].CustomerID == cu.CustomerID)
                            {
                                break;
                            }
                        }
                        dgCustomerInfo.Rows[i].Selected = true;
                        dgCustomerInfo.CurrentCell = dgCustomerInfo.Rows[i].Cells[0];
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
                    if (cuBLL.Update(cu))
                    {
                        GetCustomerInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].CustomerID == cu.CustomerID)
                            {
                                break;
                            }
                        }
                        dgCustomerInfo.Rows[i].Selected = true;
                        dgCustomerInfo.CurrentCell = dgCustomerInfo.Rows[i].Cells[0];
                        MessageBox.Show("修改记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改记录失败！");
                    }

                }
                else if (op == Operation.Delete)
                {
                    if (cuBLL.Delete(cu))
                    {

                        if (list.Count != 0)
                        {
                            GetCustomerInfo();
                            dgCustomerInfo.CurrentRow.Selected = false;
                            MessageBox.Show("删除记录成功！");
                        }
                        cu = null;
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

            string customerID = txtCustomerID.Text.Trim();
            string customerName = txtCustomerName.Text.Trim();
            string spellingCode = txtSpellingCode.Text.Trim();
            string address = txtAddress.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string tel = txtTel.Text.Trim();
            string fax = txtFax.Text.Trim();
            string bankName = txtBankName.Text.Trim();
            string bankAccount = txtBankAccount.Text.Trim();
            string contacter = txtContacter.Text.Trim();
            string email = txtEmail.Text.Trim();
            cu = new Customer(customerID, customerName, spellingCode, address, zipCode, tel, fax, bankName, bankAccount, contacter, email);
        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Common.HZToSpell(txtCustomerName.Text.Trim());
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                cu.CustomerID = qID;
                cu.CustomerName = qName;
                list = cuBLL.GetCustomerByCustomerIDAndCustomerName(cu);
                if (list.Count == 0)
                {
                    MessageBox.Show("没有您所要查找的记录！");
                    return;
                }
                else
                {
                    dgCustomerInfo.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }

}
