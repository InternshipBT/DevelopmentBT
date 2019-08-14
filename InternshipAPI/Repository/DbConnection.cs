using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace InternshipAPI.Repository
{
    public class DbConnection
    {
       

        public OracleConnection initializare ()
        {
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            OracleConnection conn = new OracleConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (OracleException ex)
            {
                var eroare= ex.Message;
            }

            return conn;
        }

    }
}