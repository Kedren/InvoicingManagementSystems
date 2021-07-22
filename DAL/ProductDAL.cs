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
    public class ProductDAL : IDAL<Product>
    {
         SqlCommand cmd;
         public ProductDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

        }
         public List<Product> GetList()
         {
             cmd.CommandText = "GetAllProduct";
             cmd.Parameters.Clear();


             List<Product> list = new List<Product>();
             SqlDataReader re = DBAccess.ExcuteReader(cmd);

             while (re.Read())
             {
                 Product ca = GetProductRow(re);
                 list.Add(ca);
             }
             re.Close();
             return list;
         }

         private static Product GetProductRow(SqlDataReader re)
         {
             string productID = re[0].ToString().Trim();
             string productName = re[1].ToString().Trim();
             string spellingCode = re[2].ToString().Trim();
             string barcode = re[3].ToString().Trim();
             string special = re[4].ToString().Trim();
             string unit = re[5].ToString().Trim();
             string origin = re[6].ToString().Trim();
             string categoryID = re[7].ToString().Trim();
             double purchasePrice = Convert.ToDouble(re[8]);
             double salePrice = Convert.ToDouble(re[9]);
             int quantity = Convert.ToInt32(re[10]);

             Product ca = new Product(productID, productName, spellingCode, barcode, special, unit, origin, categoryID, purchasePrice, salePrice, quantity);
             return ca;
         }

        public bool Insert(Product o)
        {
            cmd.CommandText = "InsertProduct";
            SetProductParemeteers(o);
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

        private void SetProductParemeteers(Product o)
        {
           
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 80).Value = o.ProductName;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 40).Value = o.SpellingCode;
            cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar, 14).Value = o.Barcode;
            cmd.Parameters.Add("@Special", SqlDbType.NVarChar, 40).Value = o.Special;
            cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 6).Value = o.Unit;
            cmd.Parameters.Add("@Origin", SqlDbType.NVarChar, 50).Value = o.Origin;
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = o.PurchasePrice;
            cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = o.SalePrice;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = o.Quantity;
        }

        public bool Delete(Product o)
        {
            cmd.CommandText = "DeleteProduct";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;
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

        public bool Update(Product o)
        {
            cmd.CommandText = "UpdateProduct";
            cmd.Parameters.Clear();
            SetProductParemeteers(o);
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

        public Product FindByID(string id)
        {
            cmd.CommandText = "FindProductByProductID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader re = DBAccess.ExcuteReader(cmd);
            if (re.Read())
            {
                Product ca = GetProductRow(re);
                re.Close();
                return ca;
            }
            else
            {
                re.Close();
                return null;
            }
        }
        public List<Product> FindProductBySpellingCode(string spellinhCode)
        {
            cmd.CommandText = "FindProductBySpellingCode";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 6).Value = spellinhCode;

            List<Product> list = new List<Product>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Product ca = GetProductRow(re);
                list.Add(ca);
            }
            re.Close();
            return list;
        }
        public List<Product> GetProductByProductIDAndProductName(Product o)
        {
            cmd.CommandText = "GetProductByProductIDAndProductName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 80).Value = o.ProductName;

            List<Product> list = new List<Product>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Product ca = GetProductRow(re);
                list.Add(ca);
            }
            re.Close();
            return list;
        }

    }
}
