using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SubCategoryClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        
        public int ManageSubCategory(int SubCategoryId, 
            int CategoryId, 
            string SubCategoryName, 
            string Description, 
            int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageSubCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
                cmd.Parameters.AddWithValue("@SubCategoryName", SubCategoryName);
                cmd.Parameters.AddWithValue("@Description", Description);
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

        public DataTable GetAllSubCategories()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select sc.SubCategoryId,sc.SubCategoryName,c.CategoryName,sc.Description from CategoryTable c, SubCategoryTable sc where sc.CategoryId=c.CategoryId", conn);
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

        public DataTable GetSubCategoryByCategoryId(int CategoryId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select sc.SubCategoryId,sc.SubCategoryName,c.CategoryName,sc.Description from CategoryTable c, SubCategoryTable sc where sc.CategoryId=c.CategoryId and c.CategoryId=@CategoryId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
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
