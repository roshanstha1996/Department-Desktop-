using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataAccessLayer
{
    public class ConnectionClass
    {
        public static string ConnectionString
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString; }
        }
    }
}