using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class SaleBill
    {
        string saleID;

        public string SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }
        string customerID;

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        DateTime saleDate;

        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }
        DateTime deliveryDate;

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }
        string clerk;

        public string Clerk
        {
            get { return clerk; }
            set { clerk = value; }
        }
        string custodian;

        public string Custodian
        {
            get { return custodian; }
            set { custodian = value; }
        }
        int onProcess;

        public int OnProcess
        {
            get { return onProcess; }
            set { onProcess = value; }
        }
        string memo;

        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
        public SaleBill()
        {

        }
        public SaleBill(string saleID, string customerID, DateTime saleDate, DateTime deliveryDate, string clerk, string custodian, int onProcess, string memo)
        {
            this.saleID = saleID;
            this.customerID = customerID;
            this.saleDate = saleDate;
            this.deliveryDate = deliveryDate;
            this.clerk = clerk;
            this.custodian = custodian;
            this.onProcess = onProcess;
            this.memo = memo;
        }

    }
}
