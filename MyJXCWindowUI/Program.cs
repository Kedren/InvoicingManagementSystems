using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuQiJing.MyJXCWindowUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BaseForm.BaseInfoForm());
            //Application.Run(new InfoManage.Frm_Category());
            //Application.Run(new InfoManage.Frm_Product());
            //Application.Run(new InfoManage.Frm_Customer());
            //Application.Run(new InfoManage.Frm_Employee());
            //Application.Run(new InfoManage.Frm_Supplier());
            //Application.Run(new BaseForm.BasePurChaseBillForm());
            //Application.Run(new PurchaseManage.Frm_FillPurchaseBill());
            //Application.Run(new PurchaseManage.Frm_ChooseProduct());
            //Application.Run(new PurchaseManage.Frm_ExamPurchaseBill());
            //Application.Run(new PurchaseManage.Frm_InStockCheck());
            //Application.Run(new UserManage.Frm_SystemUser());
            //Application.Run(new UserManage.Frm_ChangePassword());

            Application.Run(new Frm_Main());
        }
    }
}
