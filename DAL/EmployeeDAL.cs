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
    public class EmployeeDAL:IDAL<Employee>
    {
        SqlCommand cmd;
        public EmployeeDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

        }
        public List<Employee> GetList()
        {
            cmd.CommandText = "GetAllEmployee";
            cmd.Parameters.Clear();


            List<Employee> list = new List<Employee>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Employee ca = GetEmployeeRow(re);
                list.Add(ca);
            }
            re.Close();
            return list;
        }

        private static Employee GetEmployeeRow(SqlDataReader re)
        {
            string employeeID = re[0].ToString().Trim();
            string employeeName = re[1].ToString().Trim();
            int sex = Convert.ToInt32(re[2]);
            DateTime birthday = Convert.ToDateTime(re[3]);
            string brief = re[4].ToString().Trim();
            Employee ca = new Employee(employeeID, employeeName, sex, birthday, brief);
            return ca;
        }

        public bool Insert(Employee o)
        {
            cmd.CommandText = "InsertEmployee";
            SetEmployeeParameters(o);
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

        private void SetEmployeeParameters(Employee o)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = o.EmployeeName;
            cmd.Parameters.Add("@Sex", SqlDbType.Bit).Value = o.Sex;
            cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = o.Birthday; 
            cmd.Parameters.Add("@Brief", SqlDbType.NVarChar, 2000).Value = o.Brief;
        }

        public bool Delete(Employee o)
        {
            cmd.CommandText = "DeleteEmployee";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
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

        public bool Update(Employee o)
        {
            cmd.CommandText = "UpdateEmployee";
            SetEmployeeParameters(o);
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

        public Employee FindByID(string id)
        {
            cmd.CommandText = "FindEmployeeByEmployeeID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader re = DBAccess.ExcuteReader(cmd);
            if (re.Read())
            {
                Employee ca = GetEmployeeRow(re);
                re.Close();
                return ca;
            }
            else
            {
                re.Close();
                return null;
            }
        }
        public List<Employee> GetEmployeeByEmployeeIDAndEmployeeName(Employee o)
        {
            cmd.CommandText = "GetEmployeeByEmployeeIDAndEmployeeName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = o.EmployeeName;

            List<Employee> list = new List<Employee>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                Employee ca = GetEmployeeRow(re);
                list.Add(ca);
            }
            re.Close();
            return list;
        }
    }
}
