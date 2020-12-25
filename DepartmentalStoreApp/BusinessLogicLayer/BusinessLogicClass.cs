using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        ManageCategory mc = new ManageCategory();
        SubCategoryClass scc = new SubCategoryClass();
        ProductClass pc = new ProductClass();
        SalesCodeClass sct = new SalesCodeClass();
        SalesClass sc = new SalesClass();
        BillClass bc = new BillClass();
        UserClass uc = new UserClass();
        public bool MCategory(int CategoryId,
            string CategoryName,
            string Description,
            int Mode)
        {
            try
            {
                bool result = false;
                int x = mc.MCategory(CategoryId, CategoryName, Description, Mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageSubCategory(int SubCategoryId,
            int CategoryId,
            string SubCategoryName,
            string Description,
            int Mode)
        {
            try
            {
                bool result = false;
                int x = scc.ManageSubCategory(SubCategoryId, CategoryId, SubCategoryName, Description, Mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageProducts(int ProductId,
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
                bool result = false;
                int x = pc.ManageProducts(ProductId, ProductName, Rate, SubCategoryId, MfgDate, ExpDate, QuantityInStock, ThresholdValue, Mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageSCT(int SalesCodeId,
            String CustomerName,
            string SalesDate,
            string CustomerEmail,
            string ContactNumber,
            string Address,
            int Mode)
        {
            try
            {
                bool result = false;
                int x = sct.ManageSCT(SalesCodeId, CustomerName, SalesDate, CustomerEmail, ContactNumber, Address, Mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)                                                                                                                        
            {

                throw ex;
            }
        }

        public bool ManageSales(int SalesId,
             int SalesCodeId,
             int ProductId,
             int SalesQuantity,
             int Mode)
        {
            try
            {
                bool result = false;
                int x = sc.ManageSales(SalesId, SalesCodeId, ProductId, SalesQuantity, Mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageBill(int BillId,
            int SalesCodeId,
            double Discount,
            double Vat,
            double NetTotal,
            int Mode)
        {
            try
            {
                bool result = false;
                int x = bc.ManageBill(BillId, SalesCodeId, Discount, Vat, NetTotal, Mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageUser(int UserId,
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
                int x = uc.ManageUser(UserId, UserName, Password, Role, CreatedBy, CreatedDate, IsActive, Mode);
                if (x > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Login(string UserName,string Password)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = uc.Login(UserName, Password);
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
