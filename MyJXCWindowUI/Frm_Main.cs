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

namespace LuQiJing.MyJXCWindowUI
{
    public partial class Frm_Main : Form
    {
        private UserBLL usBLL;
        private User us;
        private string userID;
        private string passWord;

        //ToolStripMenuItem[] t1 = new ToolStripMenuItem[5];
        //ToolStripMenuItem[] t2 = new ToolStripMenuItem[3];
        //ToolStripMenuItem[] t3 = new ToolStripMenuItem[2];
        //ToolStripMenuItem[] t4 = new ToolStripMenuItem[2];
        public Frm_Main()
        {
            InitializeComponent();
            usBLL = new UserBLL();
            us = new User();

            //((ToolStripMenuItem)menuStrip1.Items[0]).DropDownItems.CopyTo(t1, 0);
            //((ToolStripMenuItem)menuStrip1.Items[1]).DropDownItems.CopyTo(t2, 0);
            //((ToolStripMenuItem)menuStrip1.Items[2]).DropDownItems.CopyTo(t3, 0);
            //((ToolStripMenuItem)menuStrip1.Items[3]).DropDownItems.CopyTo(t4, 0);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            UnEnableMenu();
        }

        private void UnEnableMenu()
        {
            for (int i = 0; i <= 3; i++)
            {
                ((ToolStripMenuItem)menuStrip1.Items[i]).Enabled = false;
            }
        }

        private void 产品分类管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is InfoManage.Frm_Category)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //InfoManage.Frm_Category frm = new InfoManage.Frm_Category();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            ShowMdiChild<InfoManage.Frm_Category>();
        }

        private T ShowMdiChild<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is InfoManage.Frm_Category)
                {
                    f.WindowState = FormWindowState.Maximized;
                    f.Activate();
                    return (f as T);
                }
            }

            T frm = new T();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            return frm;
        }

        private void 产品信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is InfoManage.Frm_Product)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //InfoManage.Frm_Product frm = new InfoManage.Frm_Product();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            ShowMdiChild<InfoManage.Frm_Product>();
        }

        private void 供应商信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is InfoManage.Frm_Supplier)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //InfoManage.Frm_Supplier frm = new InfoManage.Frm_Supplier();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            ShowMdiChild<InfoManage.Frm_Supplier>();
        }

        private void 客户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is InfoManage.Frm_Customer)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //InfoManage.Frm_Customer frm = new InfoManage.Frm_Customer();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            ShowMdiChild<InfoManage.Frm_Customer>();
        }

        private void 员工信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is InfoManage.Frm_Employee)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //InfoManage.Frm_Employee frm = new InfoManage.Frm_Employee();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            ShowMdiChild<InfoManage.Frm_Employee>();
        }


        private void 填写进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is PurchaseManage.Frm_FillPurchaseBill)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //PurchaseManage.Frm_FillPurchaseBill frm = new PurchaseManage.Frm_FillPurchaseBill();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.EmployeeID = userID;
            //frm.Show();

            PurchaseManage.Frm_FillPurchaseBill frm = ShowMdiChild<PurchaseManage.Frm_FillPurchaseBill>();
            frm.EmployeeID = userID;
        }

        private void 审核进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is PurchaseManage.Frm_ExamPurchaseBill)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //PurchaseManage.Frm_ExamPurchaseBill frm = new PurchaseManage.Frm_ExamPurchaseBill();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.EmployeeID = userID;
            //frm.Show();

            PurchaseManage.Frm_ExamPurchaseBill frm = ShowMdiChild<PurchaseManage.Frm_ExamPurchaseBill>();
            frm.EmployeeID = userID;
        }

        private void 检验货物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is PurchaseManage.Frm_InStockCheck)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}

            //PurchaseManage.Frm_InStockCheck frm = new PurchaseManage.Frm_InStockCheck();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.EmployeeID = userID;
            //frm.Show();

            PurchaseManage.Frm_InStockCheck frm = ShowMdiChild<PurchaseManage.Frm_InStockCheck>();
            frm.EmployeeID = userID;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is UserManage.Frm_ChangePassword)
            //    {
            //        f.WindowState = FormWindowState.Maximized;
            //        f.Activate();
            //        return;
            //    }
            //}
            //UserManage.Frm_ChangePassword frm = new UserManage.Frm_ChangePassword();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.UserID = userID;
            //frm.Show();

            UserManage.Frm_ChangePassword frm = ShowMdiChild<UserManage.Frm_ChangePassword>();
            frm.UserID = userID;
        }


        private void btnCancellation_Click(object sender, EventArgs e)
        {
            gbMess.Visible = false;
            txtUserID.Clear();
            txtPassWord.Clear();
            gbLogin.Visible = true;
            txtUserID.Focus();
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            UnEnableMenu();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                userID = txtUserID.Text.Trim();
                passWord = txtPassWord.Text.Trim();
                if (userID == "")
                {
                    MessageBox.Show("用户名不能为空！");
                    txtUserID.Focus();
                    return;
                }
                if (passWord == "")
                {
                    MessageBox.Show("密码不能不正确！");
                    txtPassWord.Focus();
                    return;
                }
                us.UserID = txtUserID.Text.Trim();
                us.PassWord = txtPassWord.Text.Trim();
                if (usBLL.User_Login(us))
                {
                    gbLogin.Visible = false;
                    gbMess.Visible = true;
                    lblUserName.Text = us.UserID;
                }
                else
                {
                    MessageBox.Show("用户名或密码不正确，请重新输入！");
                    return;
                }

                us = usBLL.FindByID(userID);

                //int baseFunction = us.BaseFunction;
                //if (baseFunction == 0)
                //{
                //    ((ToolStripMenuItem)menuStrip1.Items[0]).Enabled = false;

                //}
                //else
                //{
                //    ((ToolStripMenuItem)menuStrip1.Items[0]).Enabled = true;
                //    for (int i = 0; i < t1.Length; i++)
                //    {
                //        if (baseFunction % 2 == 0)
                //        {
                //            t1[i].Enabled = false;
                //        }
                //        else
                //        {
                //            t1[i].Enabled = true;
                //        }
                //        baseFunction /= 2;
                //    }
                //}

                NlitMenu(us.BaseFunction, 0);

                //    int purchaseFunction = us.PurchaseFunction;
                //    if (purchaseFunction == 0)
                //    {
                //        ((ToolStripMenuItem)menuStrip1.Items[1]).Enabled = false;

                //    }
                //    else
                //    {
                //        ((ToolStripMenuItem)menuStrip1.Items[1]).Enabled = true;
                //        for (int i = 0; i < t2.Length; i++)
                //        {
                //            if (purchaseFunction % 2 == 0)
                //            {
                //                t1[i].Enabled = false;
                //            }
                //            else
                //            {
                //                t1[i].Enabled = true;
                //            }
                //            purchaseFunction /= 2;
                //        }
                //    }

                NlitMenu(us.PurchaseFunction, 1);
                //    int saleFunction = us.SaleFunction;
                //    if (saleFunction == 0)
                //    {
                //        ((ToolStripMenuItem)menuStrip1.Items[2]).Enabled = false;

                //    }
                //    else
                //    {
                //        ((ToolStripMenuItem)menuStrip1.Items[2]).Enabled = true;
                //        for (int i = 0; i < t3.Length; i++)
                //        {
                //            if (saleFunction % 2 == 0)
                //            {
                //                t1[i].Enabled = false;
                //            }
                //            else
                //            {
                //                t1[i].Enabled = true;
                //            }
                //            saleFunction /= 2;
                //        }
                //    }

                NlitMenu(us.SaleFunction, 2);
                //    int UserFunction = us.UserFunction;
                //    if (UserFunction == 0)
                //    {
                //        ((ToolStripMenuItem)menuStrip1.Items[3]).Enabled = false;

                //    }
                //    else
                //    {
                //        ((ToolStripMenuItem)menuStrip1.Items[3]).Enabled = true;
                //        for (int i = 0; i < t4.Length; i++)
                //        {
                //            if (UserFunction % 2 == 0)
                //            {
                //                t1[i].Enabled = false;
                //            }
                //            else
                //            {
                //                t1[i].Enabled = true;
                //            }
                //            UserFunction /= 2;
                //        }
                //    }

                NlitMenu(us.UserFunction, 3);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private int NlitMenu(int purviewValue,int menuIndex)
        {
            int Function = purviewValue;
            if (Function == 0)
            {
                ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).Enabled = false;

            }
            else
            {
               int count= ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).DropDownItems.Count;
               ToolStripMenuItem[] t = new ToolStripMenuItem[count];
               ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).DropDownItems.CopyTo(t, 0);


                ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).Enabled = true;
                for (int i = 0; i < t.Length; i++)
                {
                    if (Function % 2 == 0)
                    {
                        t[i].Enabled = false;
                    }
                    else
                    {
                        t[i].Enabled = true;
                    }
                    Function /= 2;
                }
            }
            return Function;
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMdiChild<UserManage.Frm_SystemUser>();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
