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
    public partial class Frm_Employee : BaseForm.BaseInfoForm
    {
        private EmployeeBLL emBLL;
        private List<Employee> list;
        private Employee em;
        private int currentRowIndex;
        public Frm_Employee()
        {
            InitializeComponent();
            emBLL = new EmployeeBLL();
            em = new Employee();
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {

            try
            {
                GetEmployeeInfo();
                dgEmployeeInfo.CurrentCell.Selected = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetEmployeeInfo()
        {
            try
            {
                list = emBLL.GetList();
                dgEmployeeInfo.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgEmployeeInfo.CurrentRow.Selected = true;
            currentRowIndex = dgEmployeeInfo.CurrentRow.Index;
            em = list[currentRowIndex];
            if (op == Operation.Update || op == Operation.Delete)
            {
                SetTextBox();

            }
        }
        private void SetTextBox()
        {
            txtEmployeeID.Text = em.EmployeeID;
            txtEmployeeName.Text = em.EmployeeName;
            if (em.Sex == 1)
            {
                cbSex.Text = "男";
            }
            else
            {
                cbSex.Text = "女";
            }
            dtpBirthday.Value = em.Birthday;
            txtBrief.Text = em.Brief;
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
            cbSex.Enabled = true;
            dtpBirthday.Enabled = true;
            cbSex.Text = "";
            dtpBirthday.Value = System.DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Enabled = false;
            txtEmployeeName.Enabled = true;
            cbSex.Enabled = true;
            dtpBirthday.Enabled = true;
            txtBrief.Enabled = true;
            if (em != null)
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
            cbSex.Enabled = false;
            dtpBirthday.Enabled = false;
            if (em != null)
            {
                SetTextBox();
            }
        }

        private void dgEmployeeInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString().Trim() == "1")
                {
                    e.Value = "男";
                }
                else
                {
                    e.Value = "女";
                }

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
                        //((TextBox)c
                        return;
                    }
                }
                if (op == Operation.Insert)
                {
                    GetTextBox();

                    if (emBLL.Insert(em))
                    {
                        SetDgInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].EmployeeID == em.EmployeeID)
                            {
                                break;
                            }

                        }
                        dgEmployeeInfo.Rows[i].Selected = true;
                        dgEmployeeInfo.CurrentCell = dgEmployeeInfo.Rows[i].Cells[0];
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
                    if (emBLL.Update(em))
                    {
                        SetDgInfo();
                        int i = 0;
                        for (; i < list.Count; i++)
                        {
                            if (list[i].EmployeeID == em.EmployeeID)
                            {
                                break;
                            }
                        }
                        dgEmployeeInfo.Rows[i].Selected = true;
                        dgEmployeeInfo.CurrentCell = dgEmployeeInfo.Rows[i].Cells[0];
                        MessageBox.Show("修改记录成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改记录失败！");
                    }

                }
                else if (op == Operation.Delete)
                {
                    if (emBLL.Delete(em))
                    {
                        SetDgInfo();
                        if (list.Count != 0)
                        {
                            dgEmployeeInfo.CurrentRow.Selected = false;
                            MessageBox.Show("删除记录成功！");
                        }
                        em = null;
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
            string employeeID = txtEmployeeID.Text.Trim();
            string employeeName = txtEmployeeName.Text.Trim();
            int sex;
            if (cbSex.Text == "男")
            {
                sex = 1;
            }
            else
            {
                sex = 0;
            }
            DateTime birthday = dtpBirthday.Value.Date;
            string brief = txtBrief.Text.Trim();

            em = new Employee(employeeID, employeeName, sex, birthday, brief);
        }

        private void SetDgInfo()
        {
            try
            {
                list = emBLL.GetList();
                dgEmployeeInfo.DataSource = list;
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
                em.EmployeeID = qID;
                em.EmployeeName = qName;
                list = emBLL.GetEmployeeByEmployeeIDAndEmployeeName(em);
                if (list.Count == 0)
                {
                    MessageBox.Show("没有您所要查找的记录！");
                    return;
                }
                else
                {
                    dgEmployeeInfo.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }

}