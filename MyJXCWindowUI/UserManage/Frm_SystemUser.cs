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

namespace LuQiJing.MyJXCWindowUI.UserManage
{
    public partial class Frm_SystemUser : Form
    {
        private UserBLL usBLL;
        private User us;

        CheckBox[] c1 = new CheckBox[5];
        CheckBox[] c2 = new CheckBox[3];
        CheckBox[] c3 = new CheckBox[2];
        CheckBox[] c4 = new CheckBox[2];

        public Frm_SystemUser()
        {
            InitializeComponent();
            usBLL = new UserBLL();

            c1[0] = chkProductManager;
            c1[1] = chkProductInformation;
            c1[2] = chkSupplierInformation;
            c1[3] = chkClentInformation;
            c1[4] = chkEmployeeInformation;

            c2[0] = chkWriteBill;
            c2[1] = chkCheckBill;
            c2[2] = chkCheckCargo;

            c3[0] = chkForeSell;
            c3[1] = chkSellReturn;

            c4[0] = chkUpdatePassWord;
            c4[1] = chkUserManage;


        }
        delegate void TestDelegate(List<User> n);
        private void Frm_SystemUser_Load(object sender, EventArgs e)
        {
            try
            {
                List<User> u = usBLL.GetList();

                //linq
                List<string> idList = (from n in u where n.UserID != "admin" select n.UserID).ToList();

                lstUserList.DataSource = idList;
                lstUserList.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void lstUserList_Click(object sender, EventArgs e)
        {
            try
            {
                string id = lstUserList.SelectedItem.ToString();

                us = usBLL.FindByID(id);
                txtUserID.Text = lstUserList.SelectedItem.ToString();
                txtUserName.Text = new EmployeeBLL().FindByID(id).EmployeeName;
                txtPassWord.Text = us.PassWord;

                btnRestoreAllPurview.Enabled = btnVastRestorePurview.Enabled = btnAccRestorePurview.Enabled
                = btnSellRestorePurview.Enabled = btnUserRestorePurview.Enabled = true;

                SetCheckBox(us.BaseFunction, c1);

                //int baseFunction = us.BaseFunction;
                //for (int i = 0; i < c1.Length; i++)
                //{
                //    if (baseFunction % 2 == 0)
                //    {
                //        c1[i].Checked = false;
                //    }
                //    else
                //    {
                //        c1[i].Checked = true;
                //    }
                //    baseFunction /= 2;
                //}

                SetCheckBox(us.PurchaseFunction, c2);
                //int purchaseFunction = usBLL.FindByID(id).PurchaseFunction;
                //for (int i = 0; i < c2.Length; i++)
                //{
                //    if (purchaseFunction % 2 == 0)
                //    {
                //        c2[i].Checked = false;
                //    }
                //    else
                //    {
                //        c2[i].Checked = true;
                //    }
                //    purchaseFunction /= 2;
                //}

                SetCheckBox(us.SaleFunction, c3);
                //int saleFunction = us.SaleFunction;
                //for (int i = 0; i < c3.Length; i++)
                //{
                //    if (saleFunction % 2 == 0)
                //    {
                //        c3[i].Checked = false;
                //    }
                //    else
                //    {
                //        c3[i].Checked = true;
                //    }
                //    saleFunction /= 2;
                //}

                SetCheckBox(us.UserFunction, c4);
                //int userFunction = us.UserFunction;
                //for (int i = 0; i < c4.Length; i++)
                //{
                //    if (userFunction % 2 == 0)
                //    {
                //        c4[i].Checked = false;
                //    }
                //    else
                //    {
                //        c4[i].Checked = true;
                //    }
                //    userFunction /= 2;
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// 根据权限值设置复选框
        /// </summary>
        /// <param name="purviewValue">权限值</param>
        /// <param name="ck">复选框数组</param>
        private void SetCheckBox(int purviewValue, CheckBox[] ck)
        {
            int Function = purviewValue;
            for (int i = 0; i < ck.Length; i++)
            {
                if (Function % 2 == 0)
                {
                    ck[i].Checked = false;
                }
                else
                {
                    ck[i].Checked = true;
                }
                Function /= 2;
            }

        }

        private void btnVastSelectPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c1, true);
        }

        private void btnVastClearPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c1, false);
        }

        /// <summary>
        /// 根据bool值选择或不选择全部复选框
        /// </summary>
        /// <param name="ck">复选框数组</param>
        /// <param name="b">bool值</param>
        private void SetCkeckBoxByPurview(CheckBox[] ck, bool b)
        {
            for (int i = 0; i < ck.Length; i++)
            {
                ck[i].Checked = b;
            }
        }

        private void btnVastRestorePurview_Click(object sender, EventArgs e)
        {

            SetCheckBox(us.BaseFunction, c1);
        }

        private void btnAccSelectPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c2, true);
        }

        private void btnAccClearPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c2, false);
        }

        private void btnAccRestorePurview_Click(object sender, EventArgs e)
        {
            SetCheckBox(us.PurchaseFunction, c2);
        }

        private void btnSellRestorePurview_Click(object sender, EventArgs e)
        {
            SetCheckBox(us.SaleFunction, c3);
        }

        private void btnUserRestorePurview_Click(object sender, EventArgs e)
        {
            SetCheckBox(us.UserFunction, c4);
        }

        private void btnUserClearPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c4, false);
        }

        private void btnUserSelectPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c4, true);
        }

        private void btnSellClearPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c3, false);
        }

        private void btnSellSelectPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c3, true);
        }

        private void btnSelectAllPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c1, true);
            SetCkeckBoxByPurview(c2, true);
            SetCkeckBoxByPurview(c3, true);
            SetCkeckBoxByPurview(c4, true);
        }

        private void btnClearAllPurview_Click(object sender, EventArgs e)
        {
            SetCkeckBoxByPurview(c1, false);
            SetCkeckBoxByPurview(c2, false);
            SetCkeckBoxByPurview(c3, false);
            SetCkeckBoxByPurview(c4, false);
        }

        private void btnRestoreAllPurview_Click(object sender, EventArgs e)
        {
            SetCheckBox(us.BaseFunction, c1);
            SetCheckBox(us.PurchaseFunction, c2);
            SetCheckBox(us.SaleFunction, c3);
            SetCheckBox(us.UserFunction, c4);
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            btnRestoreAllPurview.Enabled = btnVastRestorePurview.Enabled = btnAccRestorePurview.Enabled 
            = btnSellRestorePurview.Enabled = btnUserRestorePurview.Enabled =false;
 
            txtUserID.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();

            SetCkeckBoxByPurview(c1, false);
            SetCkeckBoxByPurview(c2, false);
            SetCkeckBoxByPurview(c3, false);
            SetCkeckBoxByPurview(c4, false);

            lstUserList.SelectedIndex = -1;
            us = null;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                us.PassWord = txtPassWord.Text.Trim();

                us.BaseFunction = CalculatePurview(c1);
                us.PurchaseFunction = CalculatePurview(c2);
                us.SaleFunction = CalculatePurview(c3);
                us.UserFunction = CalculatePurview(c4);

                if (usBLL.Update(us))
                {
                    MessageBox.Show("修改成功！");
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        private static int CalculatePurview(CheckBox[] ck)
        {
            int sum = 0;
            for (int i = 0; i < ck.Length; i++)
            {
                if (ck[i].Checked)
                {
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }

    }
}
    
