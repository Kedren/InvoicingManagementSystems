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
    public class SupplierDAL : IDAL<Supplier>
    {
        SqlCommand cmd;
        public SupplierDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

        }
        public List<Supplier> GetList()
        {
            cmd.CommandText = "GetAllSupplier";
            cmd.Parameters.Clear();


            List<Supplier> list = new List<Supplier>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Supplier ca = GetSupplierRow(re);
                list.Add(ca);
            } re.Close();
            return list;

        }

        private static Supplier GetSupplierRow(SqlDataReader re)
        {

            string supplierID = re[0].ToString().Trim();
            string supplierName = re[1].ToString().Trim();
            string spellingCode = re[2].ToString().Trim();
            string address = re[3].ToString().Trim();
            string zipCode = re[4].ToString().Trim();
            string tel = re[5].ToString().Trim();
            string fax = re[6].ToString().Trim();
            string bankName = re[7].ToString().Trim();
            string bankAccount = re[8].ToString().Trim();
            string contacter = re[9].ToString().Trim();
            string email = re[10].ToString().Trim();
            Supplier ca = new Supplier(supplierID, supplierName, spellingCode, address, zipCode, tel, fax, bankName, bankAccount, contacter, email);
            return ca;
        }

        public bool Insert(Supplier o)
        {
            cmd.CommandText = "InsertSupplier";
            SetSupplierParameters(o);
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

        private void SetSupplierParameters(Supplier o)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = o.SupID;
            cmd.Parameters.Add("@supplierName", SqlDbType.NVarChar, 80).Value = o.SupName;
            cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 20).Value = o.SpeCode;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 80).Value = o.Ads;
            cmd.Parameters.Add("@zipCode", SqlDbType.Char, 6).Value = o.ZiCode;
            cmd.Parameters.Add("@tel", SqlDbType.NVarChar, 20).Value = o.Tel;
            cmd.Parameters.Add("@fax", SqlDbType.NVarChar, 20).Value = o.Fax;
            cmd.Parameters.Add("@bankName", SqlDbType.NVarChar, 40).Value = o.BkName;
            cmd.Parameters.Add("@bankAccount", SqlDbType.NVarChar, 50).Value = o.BkCount;
            cmd.Parameters.Add("@contacter", SqlDbType.NVarChar, 20).Value = o.Coter;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 30).Value = o.Email;
        }

        public bool Delete(Supplier o)
        {
            cmd.CommandText = "DeleteSupplier";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = o.SupID;
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

        public bool Update(Supplier o)
        {
            cmd.CommandText = "UpdateSupplier";
            SetSupplierParameters(o);
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

        public Supplier FindByID(string id)
        {
            cmd.CommandText = "FindSupplierBySupplierID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader re = DBAccess.ExcuteReader(cmd);
            if (re.Read())
            {
                Supplier ca = GetSupplierRow(re);
                re.Close();
                return ca;
            }
            else
            {
                re.Close();
                return null;
            }
        }
        public List<Supplier> GetSupplierBySupplierIDAndSupplierName(Supplier o)
        {
            cmd.CommandText = "GetSupplierBySupplierIDAndSupplierName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = o.SupID;
            cmd.Parameters.Add("@supplierName", SqlDbType.NVarChar, 80).Value = o.SupName;


            List<Supplier> list = new List<Supplier>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Supplier ca = GetSupplierRow(re);
                list.Add(ca);
            } re.Close();
            return list;

        }
    }
}
