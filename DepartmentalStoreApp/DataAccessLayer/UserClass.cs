using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int ManageUser(int UserId,
            string UserName,
            string Password,
            string Role,
            string CreatedBy,
            string CreatedDate,
            string IsActive,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ManageUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Role", Role);
                cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public DataTable GetAllUsers()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from UserTable", conn);
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

        public DataTable Login(string UserName, string Password)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from UserTable where UserName=@UserName and Password=@Password", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
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
