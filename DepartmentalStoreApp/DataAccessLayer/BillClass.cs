using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BillClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int ManageBill(int BillId,
            int SalesCodeId,
            double Discount,
            double Vat,
            double NetTotal,
            int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("ManageBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BillId", BillId);
                cmd.Parameters.AddWithValue("@SalesCodeId", SalesCodeId);
                cmd.Parameters.AddWithValue("@Discount", Discount);
                cmd.Parameters.AddWithValue("@Vat", Vat);
                cmd.Parameters.AddWithValue("@NetTotal", NetTotal);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public DataTable GetAllBills()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from BillTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

    }
}
