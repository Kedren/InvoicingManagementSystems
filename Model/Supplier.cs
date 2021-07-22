using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class Supplier
    {
        private string supID;

        public string SupID
        {
            get { return supID; }
            set { supID = value; }
        }
        private string supName;

        public string SupName
        {
            get { return supName; }
            set { supName = value; }
        }
        private string speCode;

        public string SpeCode
        {
            get { return speCode; }
            set { speCode = value; }
        }
        private string ads;

        public string Ads
        {
            get { return ads; }
            set { ads = value; }
        }
        private string ziCode;

        public string ZiCode
        {
            get { return ziCode; }
            set { ziCode = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        private string bkName;

        public string BkName
        {
            get { return bkName; }
            set { bkName = value; }
        }
        private string bkCount;

        public string BkCount
        {
            get { return bkCount; }
            set { bkCount = value; }
        }
        private string coter;

        public string Coter
        {
            get { return coter; }
            set { coter = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Supplier()
        {

        }
        public Supplier(string supplierID, string supplierName, string spellingCode, string address, string zipCode, string tel, string fax, string bankName, string bankAccount, string contacter, string email)
        {
            this.supID = supplierID;
            this.supName =supplierName;
            this.speCode = spellingCode;
            this.ads = address;
            this.ziCode = zipCode;
            this.tel = tel;
            this.fax = fax;
            this.bkName = bankName;
            this.bkCount = bankAccount;
            this.coter = contacter;
            this.email = email;
        }

    }
}
