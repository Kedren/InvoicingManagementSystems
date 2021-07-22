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
    public class CategoryDAL : IDAL<Category>
    {
        SqlCommand cmd;
        public CategoryDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public List<Category> GetList()
        {
            cmd.CommandText = "GetAllCategory";
            cmd.Parameters.Clear();


            List<Category> list = new List<Category>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                string id = re[0].ToString();
                string name = re[1].ToString();
                Category ca = new Category(id, name);
                list.Add(ca);
            }
            re.Close();
            return list;

        }

        public bool Insert(Category o)
        {
            cmd.CommandText = "InsertCategory";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CateID;
            cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 80).Value = o.CateName;
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

        public bool Delete(Category o)
        {
            cmd.CommandText = "DeleteCategory";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CateID;
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

        public bool Update(Category o)
        {
            cmd.CommandText = "UpdateCategory";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CateID;
            cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 80).Value = o.CateName;
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

        public Category FindByID(string id)
        {
            cmd.CommandText = "FindCategoryByCategoryID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader re = DBAccess.ExcuteReader(cmd);
            if (re.Read())
            {
                string Cid = re[0].ToString();
                string Cname = re[1].ToString();
                Category ca = new Category(Cid, Cname);
                re.Close();
                return ca;
            }
            else
            {
                re.Close();
                return null;
            }
        }
        public List<Category> GetCategoryByCategoryIDAndCategyName(Category o)
        {
            cmd.CommandText = "GetCategoryByCategoryIDAndCategyName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CateID;
            cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 80).Value = o.CateName;


            List<Category> list = new List<Category>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                string id = re[0].ToString();
                string name = re[1].ToString();
                Category ca = new Category(id, name);
                list.Add(ca);
            }
            re.Close();
            return list;
        }
    }
}
