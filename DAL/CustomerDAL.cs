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
    public class CustomerDAL : IDAL<Customer>
    {
        SqlCommand cmd;
        public CustomerDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public List<Customer> GetList()
        {
            cmd.CommandText = "GetAllCustomer";
            cmd.Parameters.Clear();


            List<Customer> list = new List<Customer>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Customer ca = GetCoutomerRow(re);
                list.Add(ca);
            }
            re.Close();
            return list;
        }

        private static Customer GetCoutomerRow(SqlDataReader re)
        {
            string customerID = re[0].ToString().Trim();
            string customerName = re[1].ToString().Trim();
            string spellingCode = re[2].ToString().Trim();
            string address = re[3].ToString().Trim();
            string zipCode = re[4].ToString().Trim();
            string tel = re[5].ToString().Trim();
            string fax = re[6].ToString().Trim();
            string bankName = re[7].ToString().Trim();
            string bankAccount = re[8].ToString().Trim();
            string contacter = re[9].ToString().Trim();
            string email = re[10].ToString().Trim();

            Customer ca = new Customer(customerID, customerName, spellingCode, address, zipCode, tel, fax, bankName, bankAccount, contacter, email);
            return ca;
        }

        public bool Insert(Customer o)
        {
            cmd.CommandText = "InsertCustomer";
            SetCustomerParameters(o);
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

        private void SetCustomerParameters(Customer o)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 80).Value = o.CustomerName;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 20).Value = o.SpellingCode;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 80).Value = o.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Char, 6).Value = o.ZipCode;
            cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = o.Tel;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 20).Value = o.Fax;
            cmd.Parameters.Add("@BankName", SqlDbType.NVarChar, 40).Value = o.BankName;
            cmd.Parameters.Add("@BankAccount", SqlDbType.NVarChar, 50).Value = o.BankAccount;
            cmd.Parameters.Add("@Contacter", SqlDbType.NVarChar, 20).Value = o.Contacter;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 30).Value = o.Email;
        }

        public bool Delete(Customer o)
        {
            cmd.CommandText = "DeleteCustomer";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
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

        public bool Update(Customer o)
        {
            cmd.CommandText = "UpdateCustomer";
            SetCustomerParameters(o);
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

        public Customer FindByID(string id)
        {
            cmd.CommandText = "FindCustomerByCustomerID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader re = DBAccess.ExcuteReader(cmd);
            if (re.Read())
            {
                Customer ca = GetCoutomerRow(re);
                re.Close();
                return ca;
            }
            else
            {
                re.Close();
                return null;
            }
        }
        public List<Customer> GetCustomerByCustomerIDAndCustomerName(Customer o)
        {
            cmd.CommandText = "GetCustomerByCustomerIDAndCustomerName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 80).Value = o.CustomerName;


            List<Customer> list = new List<Customer>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Customer ca = GetCoutomerRow(re);
                list.Add(ca);
            }
            re.Close();
            return list;
        }
    }
}
