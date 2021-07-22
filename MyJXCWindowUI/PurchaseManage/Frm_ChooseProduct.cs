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

namespace LuQiJing.MyJXCWindowUI.PurchaseManage
{
    public partial class Frm_ChooseProduct : Form
    {
        private ProductBLL prBLL;
        private List<Product> list;
        private Product pr;
        public Frm_ChooseProduct()
        {
            InitializeComponent();
            prBLL = new ProductBLL();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Frm_FillPurchaseBill.Detail_Add = null;
            this.Close();
        }

        private void txtSpellingCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string spellCode = txtSpellingCode.Text.Trim().ToUpper();
                list = prBLL.FindProductBySpellingCode(spellCode);
                dgProductInfo.DataSource = list;

                if (dgProductInfo.CurrentCell != null)
                {
                    dgProductInfo.CurrentCell.Selected = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgProductInfo.CurrentRow.Selected = true;
                pr = list[e.RowIndex];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void Frm_ChooseProduct_Load(object sender, EventArgs e)
        {
            try
            {
                list = prBLL.GetList();
                dgProductInfo.DataSource = list;

                if (dgProductInfo.CurrentCell != null)
                {
                    dgProductInfo.CurrentCell.Selected = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void dgProductInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PurchaseDetail detail_Add = new PurchaseDetail();
                detail_Add.ProductID = pr.ProductID;
                detail_Add.PurchasePrice = 0;
                detail_Add.Quantity = 0;
                Frm_FillPurchaseBill.Detail_Add = detail_Add;

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


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
    }
}

