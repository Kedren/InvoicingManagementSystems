using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class PurchaseBill
    {
        private string purchaseID;

        public string PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        private string supplierID;

        public string SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        private DateTime purchaseDate;

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }
        private DateTime stockDate;

        public DateTime StockDate
        {
            get { return stockDate; }
            set { stockDate = value; }
        }
        private string clerk;

        public string Clerk
        {
            get { return clerk; }
            set { clerk = value; }
        }
        private string examiner;

        public string Examiner
        {
            get { return examiner; }
            set { examiner = value; }
        }
        private string custodian;

        public string Custodian
        {
            get { return custodian; }
            set { custodian = value; }
        }
        private int onProcess;

        public int OnProcess
        {
            get { return onProcess; }
            set { onProcess = value; }
        }
        private string memo;

        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
        private List<PurchaseDetail> detailList;

        public List<PurchaseDetail> DetailList
        {
            get { return detailList; }
            set { detailList = value; }
        }
        public PurchaseBill()
        {

        }
        public PurchaseBill(string purchaseID, string supplierID, DateTime purchaseDate, DateTime stockDate, string clerk, string examiner, string custodian, int onProcess, string memo, List<PurchaseDetail> detailList)
        {
            this.purchaseID = purchaseID;
            this.supplierID = supplierID;
            this.purchaseDate = purchaseDate;
            this.stockDate = stockDate;
            this.clerk = clerk;
            this.examiner = examiner;
            this.custodian = custodian;
            this.onProcess = onProcess;
            this.memo = memo;
            this.detailList = detailList;
        }

    }
}
