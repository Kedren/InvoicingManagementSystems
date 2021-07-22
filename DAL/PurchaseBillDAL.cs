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
    public class PurchaseBillDAL : IDAL<PurchaseBill>
    {
        SqlCommand cmd;
        public PurchaseBillDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

        }
        public List<PurchaseBill> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Insert(PurchaseBill o)
        {
            SqlTransaction tran = DBAccess.ExecuteSQLTransaction(cmd);
            try
            {
                //插入订单信息              
                cmd.CommandText = "InsertPurchaseBill";

                SetBillParameters(o);

                cmd.ExecuteNonQuery();

                //插入订单明细信息
                cmd.CommandText = "InsertPurchaseDetail";
                cmd.Parameters.Clear();

                InsertDetail(o);
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;

            }
            finally
            {
                DBAccess.CloseTransaction();
            }
        }

        private void SetBillParameters(PurchaseBill o)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = o.PurchaseID;
            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
            cmd.Parameters.Add("@PurchaseDate", SqlDbType.DateTime).Value = o.PurchaseDate;
            if (o.StockDate == DateTime.MinValue)
            {
                cmd.Parameters.Add("@StockDate", SqlDbType.DateTime).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@StockDate", SqlDbType.DateTime).Value = o.StockDate;
            }
            cmd.Parameters.Add("@Clerk", SqlDbType.NVarChar, 6).Value = o.Clerk;
            if (o.Examiner == "")
            {
                cmd.Parameters.Add("@Examiner", SqlDbType.NVarChar, 6).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@Examiner", SqlDbType.NVarChar, 6).Value = o.Examiner;
            }
            if (o.Custodian == "")
            {
                cmd.Parameters.Add("@Custodian", SqlDbType.NVarChar, 6).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@Custodian", SqlDbType.NVarChar, 6).Value = o.Custodian;
            }
            cmd.Parameters.Add("@OnProcess", SqlDbType.SmallInt).Value = o.OnProcess;
            if (o.Memo == "")
            {
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 100).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 100).Value = o.Memo;
            }
        }

        public bool Delete(PurchaseBill o)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetailOnly(PurchaseBill o)
        {
            cmd.CommandText = "UpdatePurchaseBill";

            SetBillParameters(o);

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
        public bool Update(PurchaseBill o)
        {
            SqlTransaction tran = DBAccess.ExecuteSQLTransaction(cmd);
            try
            {
                //更新订单表
                cmd.CommandText = "UpdatePurchaseBill";

                SetBillParameters(o);
                cmd.ExecuteNonQuery();

                //删除所有订单明细
                cmd.CommandText = "DeletePurchaseDetailByPurchaseID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = o.PurchaseID;
                cmd.ExecuteNonQuery();

                //插入所有订单明细
                cmd.CommandText = "InsertPurchaseDetail";
                InsertDetail(o);

                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;

            }
            finally
            {
                DBAccess.CloseTransaction();
            }

        }

        private void InsertDetail(PurchaseBill o)
        {
            foreach (PurchaseDetail d in o.DetailList)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = d.PurchaseID;
                cmd.Parameters.Add("@PurchaseDetailID", SqlDbType.SmallInt).Value = d.PurchaseDetailID;
                cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = d.ProductID;
                cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = d.PurchasePrice;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = d.Quantity;
                cmd.ExecuteNonQuery();
            }
        }
        public PurchaseBill FindByID(string id)
        {
            //查询订单明细
            cmd.CommandText = "FindPurchaseDetailByPurchaseID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = id;

            List<PurchaseDetail> delist = new List<PurchaseDetail>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                string purchaseID = re[0].ToString().Trim();
                int purchaseDetailID = Convert.ToInt32(re[1]);
                string productID = re[2].ToString().Trim();
                decimal purchasePrice = Convert.ToDecimal(re[3]);
                int quantity = Convert.ToInt32(re[4]);
                PurchaseDetail de = new PurchaseDetail(purchaseID, purchaseDetailID, productID, purchasePrice, quantity);
                delist.Add(de);
            }
            re.Close();


            //查询一笔订单
            cmd.CommandText = "FindPurchaseBillByPurchaseID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = id;

            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            if (reader.Read())
            {
                string purchaseID = reader[0].ToString().Trim();
                string supplierID = reader[1].ToString().Trim();
                DateTime purchaseDate = Convert.ToDateTime(reader[2]);

                DateTime stockDate;
                if (reader[3] != DBNull.Value)
                {
                    stockDate = Convert.ToDateTime(reader[3]);
                }
                else
                {
                    stockDate = DateTime.MinValue;
                }
                string clerk = reader[4].ToString().Trim();
                string examiner = reader[5].ToString().Trim();
                string custodian = reader[6].ToString().Trim();
                int onProcess = Convert.ToInt32(reader[7]);
                string memo = reader[8].ToString().Trim();

                PurchaseBill pur = new PurchaseBill(purchaseID, supplierID, purchaseDate, stockDate, clerk, examiner, custodian, onProcess, memo, delist);
                reader.Close();
                return pur;
            }
            else
            {
                reader.Close();
                return null;
            }



        }

        public List<string> FindPurchaseIDByPurchaseID(string id)
        {
            cmd.CommandText = "FindPurchaseIDByPurchaseID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = id;

            List<string> list = new List<string>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                list.Add(re[0].ToString().Trim());
            }
            re.Close();
            return list;
        }
        public List<string> FindPurchaseIDByClerk(string employeeName)
        {
            cmd.CommandText = "FindPurchaseIDByClerk";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = employeeName;

            List<string> list = new List<string>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                list.Add(re[0].ToString().Trim());
            }
            re.Close();
            return list;
        }




        public List<string> FindPurchaseIDByExaminer(string employeeName)
        {
            cmd.CommandText = "FindPurchaseIDByExaminer";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = employeeName;

            List<string> list = new List<string>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                list.Add(re[0].ToString().Trim());
            }
            re.Close();
            return list;
        }
        public List<string> FindPurchaseIDByOnProcess(int onProcess)
        {
            cmd.CommandText = "FindPurchaseIDByOnProcess";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@OnProcess", SqlDbType.SmallInt).Value = onProcess;

            List<string> list = new List<string>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                list.Add(re[0].ToString().Trim());
            }
            re.Close();
            return list;
        }

        public List<string> FindPurchaseIDByPurchaseDate(DateTime startDate, DateTime endDate)
        {
            cmd.CommandText = "FindPurchaseIDByPurchaseDate";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
            cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = endDate;

            List<string> list = new List<string>();
            SqlDataReader re = DBAccess.ExcuteReader(cmd);

            while (re.Read())
            {
                list.Add(re[0].ToString().Trim());
            }
            re.Close();
            return list;
        }
        public string CreatePurchaseID(DateTime purchaseDate)
        {
            cmd.CommandText = "CreatePurchaseID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseDate", SqlDbType.DateTime).Value = purchaseDate;

            object o = DBAccess.GetScalar(cmd);
            return o.ToString();
        }

    }
}
