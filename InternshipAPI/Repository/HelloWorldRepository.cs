using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternshipAPI.Repository
{
    public class HelloWorldRepository
    {
        public string Say_Hello(string name)
        {
            DbConnection db = new DbConnection();
            OracleConnection conn = db.initializare();

            OracleCommand command = conn.CreateCommand();
            command.CommandText = Query.allusers;

            OracleDataReader reader = command.ExecuteReader();
            string usernames = "";
            while (reader.Read())
            {
                string username = reader["username"].ToString();
                username = username + username + "r\n";
            }

            if (conn.State == System.Data.ConnectionState.Open) {
                return "connected";
            }

            //OracleCommand comand = conn.CreateCommand();
            //comand.CommandText = Query.allusers;

            //OracleDataReader reader = comand.ExecuteReader();
            //string usernames = "";

            //while(reader.Read())
            //{
            //    string username = reader["username"].ToString();
            //    usernames = usernames + username + "--";
            //}

            return "usernames,"+name+"!";



        }
    }
}