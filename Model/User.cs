using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
   public class User
    {
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private int baseFunction;

        public int BaseFunction
        {
            get { return baseFunction; }
            set { baseFunction = value; }
        }
        private int purchaseFunction;

        public int PurchaseFunction
        {
            get { return purchaseFunction; }
            set { purchaseFunction = value; }
        }
        private int saleFunction;

        public int SaleFunction
        {
            get { return saleFunction; }
            set { saleFunction = value; }
        }
        private int userFunction;

        public int UserFunction
        {
            get { return userFunction; }
            set { userFunction = value; }
        }
       public User()
        {

        }
       public User(string userID,string passWord,int baseFunction,int purchaseFunction,int saleFunction,int userFunction)
       {
           this.userID = userID;
           this.passWord = passWord;
           this.baseFunction = baseFunction;
           this.purchaseFunction = purchaseFunction;
           this.saleFunction = saleFunction;
           this.userFunction = userFunction;
       }

    }
}
