using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class Product
    {
        private string productID;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string spellingCode;

        public string SpellingCode
        {
            get { return spellingCode; }
            set { spellingCode = value; }
        }
        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        private string special;

        public string Special
        {
            get { return special; }
            set { special = value; }
        }
        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        private string origin;

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        private string categoryID;

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        private double purchasePrice;

        public double PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        private double salePrice;

        public double SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Product()
        {

        }
        public Product(string productID,string productName,string spellingCode,string barcode,string special,string unit,string origin,string categoryID,double purchasePrice,double salePrice,int quantity)
        {
            this.productID = productID;
            this.productName=productName;
            this.spellingCode = spellingCode;
            this.barcode = barcode;
            this.special = special;
            this.unit = unit;
            this.origin = origin;
            this.categoryID = categoryID;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.quantity = quantity;
        }

    }
}
