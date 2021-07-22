using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using System.Data.SqlClient;
using System.Data;
using LuQiJing.DBUtility;

namespace LuQiJing.DAL
{
    public class UserDAL : IDAL<User>
    {

        SqlCommand cmd;
        public UserDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public List<User> GetList()
        {
            cmd.CommandText = "GetAllSystemUser";
            cmd.Parameters.Clear();


            List<User> list = new List<User>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                User us = GetUserRow(re);
                list.Add(us);
            }
            re.Close();
            return list;
        }

        private static User GetUserRow(SqlDataReader re)
        {
            string userID= re[0].ToString().Trim();
            string passWord = re[1].ToString().Trim();
            int baseFunction = Convert.ToInt32(re[2]);
            int purchaseFunction = Convert.ToInt32(re[3]);
            int saleFunction = Convert.ToInt32(re[4]);
            int userFunction = Convert.ToInt32(re[5]);
           
          
            User us = new User(userID,passWord,baseFunction,purchaseFunction,saleFunction,userFunction);
            return us;
        }



        public bool Insert(User o)
        {
            cmd.CommandText = "InsertSystemUser";
            SetUserParemers(o);
            try
            {
                int num = DBAccess.ExecuteSQL(cmd);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(User o)
        {
            cmd.CommandText = "DeleteSystemUser";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 6).Value = o.UserID;
            try
            {
                int num = DBAccess.ExecuteSQL(cmd);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(User o)
        {
            cmd.CommandText = "UpdateSystemUser";
            SetUserParemers(o);
            try
            {
                int num = DBAccess.ExecuteSQL(cmd);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void SetUserParemers(User o)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserId", SqlDbType.NVarChar, 6).Value = o.UserID;
            cmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 10).Value = o.PassWord;
            cmd.Parameters.Add("@BaseFunction", SqlDbType.Int).Value = o.BaseFunction;
            cmd.Parameters.Add("@PurchaseFunction", SqlDbType.Int).Value = o.PurchaseFunction;
            cmd.Parameters.Add("@SaleFunction", SqlDbType.Int).Value = o.SaleFunction;
            cmd.Parameters.Add("@UserFunction", SqlDbType.Int).Value = o.UserFunction;
        }

        public User FindByID(string id)
        {

            cmd.CommandText = "FindSystemUserByUserID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader re = DBAccess.ExcuteReader(cmd);
            if (re.Read())
            {
                User us = GetUserRow(re);
                re.Close();
                return us;
            }
            else
            {
                re.Close();
                return null;
            }
        }
        public bool User_Login(User o)
        {
            cmd.CommandText = "User_Login";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 6).Value = o.UserID;
            cmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 10).Value = o.PassWord;
            try
            {
                object b = DBAccess.GetScalar(cmd);
                if (Convert.ToInt32(b) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
     
    }
}
