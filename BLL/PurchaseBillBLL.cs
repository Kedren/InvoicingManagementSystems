using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class PurchaseBillBLL
    {
        private PurchaseBillDAL pur;
        public PurchaseBillBLL()
        {
            pur = new PurchaseBillDAL();
        }
        public List<string> FindPurchaseIDByPurchaseID(string id)
        {
            return pur.FindPurchaseIDByPurchaseID(id);
        }
        public List<string> FindPurchaseIDByClerk(string employeeName)
        {
            return pur.FindPurchaseIDByClerk(employeeName);
        }
        public List<string> FindPurchaseIDByExaminer(string employeeName)
        {
            return pur.FindPurchaseIDByExaminer(employeeName);

        }
        public List<string> FindPurchaseIDByOnProcess(int onProcess)
        {
            return pur.FindPurchaseIDByOnProcess(onProcess);
        }
        public List<string> FindPurchaseIDByPurchaseDate(DateTime startDate, DateTime endDate)
        {
            return pur.FindPurchaseIDByPurchaseDate(startDate, endDate);
        }
        public PurchaseBill FindByID(string id)
        {
            return pur.FindByID(id);
        }
        public bool Insert(PurchaseBill o)
        {
            return pur.Insert(o);
        }
        public bool Update(PurchaseBill o)
        {
            return pur.Update(o);
        }
        public bool UpdateDetailOnly(PurchaseBill o)
        {
            return pur.UpdateDetailOnly(o);
        }
        public string CreatePurchaseID(DateTime purchaseDate)
        {
            return pur.CreatePurchaseID(purchaseDate);
        }
    }
}
