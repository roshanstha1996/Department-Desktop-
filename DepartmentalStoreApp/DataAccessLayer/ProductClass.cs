using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int ManageProducts(int ProductId,
            String ProductName,
            double Rate,
            int SubCategoryId,
            String MfgDate,
            String ExpDate,
            int QuantityInStock,
            int ThresholdValue,
            int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("ManageProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", ProductId);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@Rate", Rate);
                cmd.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
                cmd.Parameters.AddWithValue("@MfgDate", MfgDate);
                cmd.Parameters.AddWithValue("@ExpDate", ExpDate);
                cmd.Parameters.AddWithValue("@QuantityInStock", QuantityInStock);
                cmd.Parameters.AddWithValue("@ThresholdValue", ThresholdValue);
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

        public DataTable GetAllProducts()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select p.ProductId,s.SubCategoryName,p.ProductName,p.Rate,p.QuantityInStock,p.ThresholdValue,p.MfgDate,p.ExpDate from ProductTable p, SubCategoryTable s where p.SubCategoryId=s.SubCategoryId", conn);
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
        
        public DataTable GetProductBySubCategoryId(int SubCategoryId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select p.ProductId,s.SubCategoryName,p.ProductName,p.Rate,p.QuantityInStock,p.ThresholdValue,p.MfgDate,p.ExpDate from ProductTable p, SubCategoryTable s where p.SubCategoryId=s.SubCategoryId and s.SubCategoryId=@SubCategoryId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
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
