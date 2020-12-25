using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SalesClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int ManageSales(int SalesId,
            int SalesCodeId,
            int ProductId,
            int SalesQuantity,
            int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("ManageST", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesId", SalesId);
                cmd.Parameters.AddWithValue("@SalesCodeId", SalesCodeId);
                cmd.Parameters.AddWithValue("@ProductId", ProductId);
                cmd.Parameters.AddWithValue("@SalesQuantity", SalesQuantity);
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

        public DataTable GetAllSales(int SalesCodeId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select s.SalesId,p.ProductId,p.ProductName,p.Rate,s.SalesQuantity,Amount=p.Rate*s.SalesQuantity from SalesTable s,ProductTable p where s.ProductId=p.ProductId and s.SalesCodeId=@SalesCodeId", conn);
                cmd.Parameters.AddWithValue("@SalesCodeId", SalesCodeId);
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
