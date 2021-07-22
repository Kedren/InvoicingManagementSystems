using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
   public class Customer
    {
        private string customerID;

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private string spellingCode;

        public string SpellingCode
        {
            get { return spellingCode; }
            set { spellingCode = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
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
        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        private string bankAccount;

        public string BankAccount
        {
            get { return bankAccount; }
            set { bankAccount = value; }
        }
        private string contacter;

        public string Contacter
        {
            get { return contacter; }
            set { contacter = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Customer()
        {

        }

        public Customer(string customerID,string customerName,string spellingCode,string address,string zipCode,string tel,string fax,string bankName,string bankAccount,string contacter,string email)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.spellingCode = spellingCode;
            this.address = address;
            this.zipCode = zipCode;
            this.tel = tel;
            this.fax = fax;
            this.bankName = bankName;
            this.bankAccount = bankAccount;
            this.contacter = contacter;
            this.email = email;
        }
    }
}
