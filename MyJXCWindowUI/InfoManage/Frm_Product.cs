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
    public partial class Frm_Product : BaseForm.BaseInfoForm
    {
        private ProductBLL prBLL;
        private CategoryBLL caBLL;
        private List<Product> list;
        private Product pr;
        private int currentRowIndex;
        public Frm_Product()
        {
            InitializeComponent();
            prBLL = new ProductBLL();
            caBLL = new CategoryBLL();
            pr = new Product();
        }


        private void Frm_Product_Load(object sender, EventArgs e)
        {
            try
            {
                GetProductInfo();
                dgProductInfo.CurrentCell.Selected = false;

                cbCategoryID.DataSource = new CategoryBLL().GetList();
                cbCategoryID.ValueMember = "CateID";
                cbCategoryID.DisplayMember = "CateName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetProductInfo()
        {
            try
            {
                list = prBLL.GetList();
                dgProductInfo.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgProductInfo.CurrentRow.Selected = true;
            currentRowIndex = dgProductInfo.CurrentRow.Index;
            pr = list[currentRowIndex];
            if (op == Operation.Update || op == Operation.Delete)
            {
                SetTextBox();

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
            cbCategoryID.Enabled = true;
            txtSpellingCode.Enabled = false;
            txtPurchasePrice.Enabled = false;
            txtPurchasePrice.Text = "0";
            txtSalePrice.Enabled = false;
            txtSalePrice.Text = "0";
            txtQuantity.Enabled = false;
            txtQuantity.Text = "0";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cbCategoryID.Enabled = true;
            foreach (Control c in gbInfo.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
            }
            txtSpellingCode.Enabled = false;
            txtProductID.Enabled = false;

            if (pr != null)
            {
                SetTextBox();
            }

            txtSpellingCode.Enabled = false;
            txtProductID.Enabled = false;
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
            cbCategoryID.Enabled = false;

            if (pr != null)
            {
                SetTextBox();
            }

        }

        private void SetTextBox()
        {
            txtProductID.Text = pr.ProductID;
            txtProductName.Text = pr.ProductName;
            txtSpellingCode.Text = pr.SpellingCode;
            txtBarcode.Text = pr.Barcode;
            txtSpecial.Text = pr.Special;
            txtUnit.Text = pr.Unit;
            txtOrigin.Text = pr.Origin;
            if (pr.CategoryID!=null)
            {
                cbCategoryID.SelectedValue = pr.CategoryID;
            }          
            txtPurchasePrice.Text = pr.PurchasePrice.ToString();
            txtSalePrice.Text = pr.SalePrice.ToString();
            txtQuantity.Text = pr.Quantity.ToString();
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
                    if (prBLL.Insert(pr))
                    {
                        GetProductInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].CategoryID == pr.CategoryID)
                            {
                                break;
                            }

                        }
                        dgProductInfo.Rows[i].Selected = true;
                        dgProductInfo.CurrentCell = dgProductInfo.Rows[i].Cells[0];
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
                    if (prBLL.Update(pr))
                    {
                        GetProductInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].ProductID == pr.ProductID)
                            {
                                break;
                            }
                        }
                        dgProductInfo.Rows[i].Selected = true;
                        dgProductInfo.CurrentCell = dgProductInfo.Rows[i].Cells[0];
                        MessageBox.Show("修改记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改记录失败！");
                    }

                }
                else if (op == Operation.Delete)
                {
                    if (prBLL.Delete(pr))
                    {

                        if (list.Count != 0)
                        {
                            GetProductInfo();
                            dgProductInfo.CurrentRow.Selected = false;
                            MessageBox.Show("删除记录成功！");
                        }
                        pr = null;
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
            string productID = txtProductID.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string spellingCode = txtSpellingCode.Text.Trim();
            string barCode = txtBarcode.Text.Trim();
            string special = txtSpecial.Text.Trim();
            string unit = txtUnit.Text.Trim();
            string oringin = txtOrigin.Text.Trim();
            string categoryID = Convert.ToString(cbCategoryID.SelectedValue);
            double purchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
            double selePrice = Convert.ToDouble(txtSalePrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            pr = new Product(productID, productName, spellingCode, barCode, special, unit, oringin, categoryID, purchasePrice, selePrice, quantity);
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Common.HZToSpell(txtProductName.Text.Trim());
        }
        private void dgProductInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    e.Value = new CategoryBLL().FindByID(e.Value.ToString().Trim()).CateName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                pr.ProductID = qID;
                pr.ProductName = qName;
                list = prBLL.GetProductByProductIDAndProductName(pr);
                if (list.Count == 0)
                {
                    MessageBox.Show("没有您所要查找的记录！");
                    return;
                }
                else
                {
                    dgProductInfo.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
