using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class SaleDetail
    {
        string saleID;

        public string SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }
        int saleDetailID;

        public int SaleDetailID
        {
            get { return saleDetailID; }
            set { saleDetailID = value; }
        }
        string productID;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        decimal salePrice;

        public decimal SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public SaleDetail()
        {

        }
        public SaleDetail(string saleID, int saleDetailID, string productID, decimal salePrice, int quantity)
        {
            this.saleID = saleID;
            this.saleDetailID = saleDetailID;
            this.productID = productID;
            this.salePrice = salePrice;
            this.quantity = quantity;
        }

    }
}
