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

namespace LuQiJing.MyJXCWindowUI.PurchaseManage
{
    public partial class Frm_InStockCheck : BaseForm.BasePurChaseBillForm
    {
        private EmployeeBLL emBLL;
        private PurchaseBillBLL purBLL;
        public Frm_InStockCheck()
        {
            InitializeComponent();
            purBLL = new PurchaseBillBLL();
            emBLL = new EmployeeBLL();
        }

        private void lstPurchaseIDList_Click(object sender, EventArgs e)
        {
            try
            {
                txtSalesman.Text = emBLL.FindByID(pur.Clerk).EmployeeName;
                if (pur.Examiner != "")
                {
                    txtAuditor.Text = emBLL.FindByID(pur.Examiner).EmployeeName;
                }
                else
                {
                    txtAuditor.Text = "";
                }
                if (pur.Custodian != "")
                {
                    txtStorekeeper.Text = emBLL.FindByID(pur.Custodian).EmployeeName;
                }
                else
                {
                    txtStorekeeper.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (pur == null)
                {
                    MessageBox.Show("请选择一笔订单！");
                    return;
                }
                if (pur.OnProcess == 1 || pur.OnProcess == 2)
                {
                    MessageBox.Show("该订货单已撤销或完成，不能进行货物入库验收签名！");
                    return;
                }
                if (pur.Examiner == "")
                {
                    MessageBox.Show("该订货单未审核，不能进行货物入库验收签名！");
                    return;
                }

                pur.StockDate = DateTime.Now;
                pur.OnProcess = 2;
                pur.Custodian = EmployeeID;

                if (purBLL.UpdateDetailOnly(pur))
                {
                    MessageBox.Show("货物入库验收成功！");
                    txtStorageDate.Text = pur.StockDate.ToLongDateString();
                    txtState.Text = "完成";
                    txtStorekeeper.Text = emBLL.FindByID(pur.Custodian).EmployeeName;
                }
                else
                {
                    MessageBox.Show("货物入库验收失败！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            try
            {
                if (pur == null)
                {
                    MessageBox.Show("请选择一笔订单！");
                    return;
                }
                if (pur.OnProcess == 2)
                {
                    MessageBox.Show("该订单已完成，不能进行撤销！");
                    return;
                }
                if (pur.OnProcess == 1)
                {
                    MessageBox.Show("该订单已撤销，请不要重复撤销！");
                    return;
                }
                pur.OnProcess = 1;
                pur.Memo = txtNote.Text.ToString().Trim();
                if (purBLL.UpdateDetailOnly(pur))
                {
                    MessageBox.Show("订单撤销成功！");
                    txtState.Text = "撤销";
                }
                else
                {
                    MessageBox.Show("订单撤销失败！");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                if (pur == null)
                {
                    MessageBox.Show("请选择一笔订单！");
                    return;
                }
                if (pur.OnProcess == 2)
                {
                    MessageBox.Show("该订单已完成，不能进行恢复！");
                    return;
                }
                if (pur.OnProcess == 0)
                {
                    MessageBox.Show("该订单未撤销，不能进行恢复！");
                    return;
                }
                pur.OnProcess = 0;
                if (purBLL.UpdateDetailOnly(pur))
                {
                    MessageBox.Show("订单恢复成功！");
                    if (pur.Examiner == "")
                    {
                        txtState.Text = "执行（未审核）";
                    }
                    else
                    {
                        txtState.Text = "执行（已审核）";
                    }
                }
                else
                {
                    MessageBox.Show("订单恢复失败！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


    }
}
