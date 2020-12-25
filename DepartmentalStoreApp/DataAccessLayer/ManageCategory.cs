using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ManageCategory
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int MCategory(int CategoryId, string CategoryName, string Description, int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
                cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (System.Exception ex)
            {
              
                throw ex;
            }
            finally { conn.Close(); }
        }

        public DataTable GetAllCategories()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from CategoryTable", conn);
                cmd.CommandType = CommandType.Text;
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
