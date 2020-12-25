using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace DataAccessLayer
{
    public class SalesCodeClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int ManageSCT(int SalesCodeId,
            String CustomerName,
            string SalesDate,
            string CustomerEmail,
            string ContactNumber,
            string Address,
            int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("ManageSCT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesCodeId", SalesCodeId);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@SalesDate", SalesDate);
                cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                cmd.Parameters.AddWithValue("@Address", Address);
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

        public DataTable GetAllSalesCode()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from SalesCodeTable", conn);
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

        public string GetSalesCodeId()
        {
            string SalesCodeId = "";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select  max(SalesCodeId) from SalesCodeTable", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            SalesCodeId = dt.Rows[0][0].ToString();
            return SalesCodeId;
        } 
    }
}
