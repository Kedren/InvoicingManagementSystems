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
    public partial class Frm_Category : BaseForm.BaseInfoForm
    {
        private CategoryBLL cBLL;
        private List<Category> list;
        private Category ca;
        private int currentRowIndex;
        public Frm_Category()
        {
            InitializeComponent();
            cBLL = new CategoryBLL();
            ca = new Category();
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            try
            {
                SetDgInfo();
                dgCategoryInfo.CurrentCell.Selected = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgCategoryInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgCategoryInfo.CurrentRow.Selected = true;
            currentRowIndex = dgCategoryInfo.CurrentRow.Index;
            ca = list[currentRowIndex];
            if (op == Operation.Update || op == Operation.Delete)
            {
                SetTxtBox();
            }
        }

        private void SetTxtBox()
        {

            txtCategoryID.Text = ca.CateID;
            txtCategoryName.Text = ca.CateName;
        }

        private void btnNewInsert_Click(object sender, EventArgs e)
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtCategoryID.Enabled = true;
            txtCategoryName.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ca != null)
            {
                SetTxtBox();
            }
            txtCategoryID.Enabled = false;
            txtCategoryName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ca != null)
            {
                SetTxtBox();
            }
            txtCategoryID.Enabled = false;
            txtCategoryName.Enabled = false;
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
                        //((TextBox)c
                        return;
                    }
                }
                if (op == Operation.Insert)
                {
                    ca = new Category(txtCategoryID.Text.Trim(), txtCategoryName.Text.Trim());
                    if (cBLL.Insert(ca))
                    {
                        SetDgInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].CateID == ca.CateID)
                            {
                                break;
                            }

                        }
                        dgCategoryInfo.Rows[i].Selected = true;
                        dgCategoryInfo.CurrentCell = dgCategoryInfo.Rows[i].Cells[0];
                        MessageBox.Show("新增记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("新增记录失败！");
                    }

                }
                else if (op == Operation.Update)
                {
                    ca.CateName = txtCategoryName.Text.Trim();
                    if (cBLL.Update(ca))
                    {
                        SetDgInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].CateID == ca.CateID)
                            {
                                break;
                            }
                        }
                        dgCategoryInfo.Rows[i].Selected = true;
                        dgCategoryInfo.CurrentCell = dgCategoryInfo.Rows[i].Cells[0];
                        MessageBox.Show("修改记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改记录失败！");
                    }

                }
                else if (op == Operation.Delete)
                {
                    if (cBLL.Delete(ca))
                    {
                        SetDgInfo();
                        if (list.Count != 0)
                        {
                            dgCategoryInfo.CurrentRow.Selected = false;
                            MessageBox.Show("删除记录成功！");
                        }
                        ca = null;
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

        private void SetDgInfo()
        {
            try
            {
                list = cBLL.GetList();
                dgCategoryInfo.DataSource = list;

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
                ca.CateID = qID;
                ca.CateName = qName;
                list = cBLL.GetCategoryByCategoryIDAndCategyName(ca);
                if (list.Count == 0)
                {
                    MessageBox.Show("没有您所要查找的记录！");
                    return;
                }
                else
                {
                    dgCategoryInfo.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
