using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class PurchaseDetail
    {
        private string purchaseID;

        public string PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        private int purchaseDetailID;

        public int PurchaseDetailID
        {
            get { return purchaseDetailID; }
            set { purchaseDetailID = value; }
        }
        private string productID;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        private decimal purchasePrice;

        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal Account
        {
            get
            {
                return purchasePrice * quantity;
            }
        }
        public PurchaseDetail()
        {

        }
        public PurchaseDetail(string purchaseID,int purchaseDetailID,string productID,decimal  purchasePrice,int quantity
)
        {
            this.purchaseID = purchaseID;
            this.purchaseDetailID = purchaseDetailID;
            this.productID = productID;
            this.purchasePrice = purchasePrice;
            this.quantity = quantity;
        }

    }
}
