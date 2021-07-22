using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class SystemUser
    {
        string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        int baseFunction;

        public int BaseFunction
        {
            get { return baseFunction; }
            set { baseFunction = value; }
        }
        int purchaseFunction;

        public int PurchaseFunction
        {
            get { return purchaseFunction; }
            set { purchaseFunction = value; }
        }
        int saleFunction;

        public int SaleFunction
        {
            get { return saleFunction; }
            set { saleFunction = value; }
        }
        int userFunction;

        public int UserFunction
        {
            get { return userFunction; }
            set { userFunction = value; }
        }
        public SystemUser()
        {

        }
        public SystemUser(string userID,string password,int baseFunction, int purchaseFunction,int saleFunction,int userFunction)
        {
            this.userID = userID;
            this.password = password;
            this.baseFunction = baseFunction;
            this.purchaseFunction = purchaseFunction;
            this.saleFunction = saleFunction;
            this.userFunction = userFunction;
        }       
    }
}
