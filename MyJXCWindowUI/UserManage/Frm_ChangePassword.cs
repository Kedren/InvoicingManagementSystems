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

namespace LuQiJing.MyJXCWindowUI.UserManage
{
    public partial class Frm_ChangePassword : Form
    {
        private UserBLL usBLL;
        private User us;
        private string userID;

        public string UserID
        {
            set { userID = value; }
        }
        public Frm_ChangePassword()
        {
            InitializeComponent();
            usBLL = new UserBLL();
            us = new User();
        }

        private void btnConfirmF_Click(object sender, EventArgs e)
        {
            try
            {
                us = usBLL.FindByID(userID);

                string originslPwd = txtOriginalPWD.Text.Trim();
                string newPwd = txtNewPWD.Text.Trim();
                string confirmPwd = txtConfirmPWD.Text.Trim();

                us.UserID = userID;
                us.PassWord = originslPwd;
                if (usBLL.User_Login(us))
                {
                    if (newPwd != confirmPwd)
                    {
                        MessageBox.Show("两次密码不一致！");
                        return;
                    }
                    us.PassWord = newPwd;
                    if (usBLL.Update(us))
                    {
                        MessageBox.Show("修改成功！");
                        CleartxtBox();
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("原始密码不正确！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelF_Click(object sender, EventArgs e)
        {
            CleartxtBox();
        }

        private void CleartxtBox()
        {
            txtOriginalPWD.Clear();
            txtNewPWD.Clear();
            txtConfirmPWD.Clear();
        }


    }
}
