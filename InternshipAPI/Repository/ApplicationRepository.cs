using InternshipAPI.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InternshipAPI.Repository
{
    public class ApplicationRepository
    {
        private  DbConnection db = new DbConnection();
        private OracleCommand command;
        private OracleDataReader reader;
        private OracleDataAdapter adapter;
        public List<ApplicationModel> getFavApps(int userId)
           
        {
            OracleConnection conn = db.initializare();
           
            List<ApplicationModel> favs = new List<ApplicationModel>();
            int app_id;
            string url;
            string icon;
            string screenshot;
            int status = 1;
            string app_name;
            string browser;

           
            try
            {
                command = new OracleCommand(Query.favApps, conn);
                command.Parameters.Add(new OracleParameter("userid", userId));

                reader = command.ExecuteReader();

                while (reader.Read())

                {
                    app_id = Int32.Parse(reader["app_id"].ToString());
                    url = reader["url"].ToString();
                    icon = reader["icon"].ToString();
                    screenshot = reader["screenshot"].ToString();
                   
                    app_name = reader["app_name"].ToString();
                    browser = reader["browser"].ToString();

                    ApplicationModel app = new ApplicationModel(app_id, url, icon, screenshot, status, app_name, browser);

                    favs.Add(app);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            
            return favs;
        }
        public List<ApplicationModel> getLast3App(int userId)
        {
            DataTable datatable = new DataTable();
            OracleConnection conn = db.initializare();
            
            List<ApplicationModel> last3application = new List<ApplicationModel>();
            int app_id;
            string url;
            string icon;
            string screenshot;
            int status = 1;
            string app_name;
            string browser;


            try
            {
                command = new OracleCommand(Query.las3app, conn);
                command.Parameters.Add(new OracleParameter("userid", userId));

                adapter = new OracleDataAdapter(command);
                adapter.Fill(datatable);
             
                 foreach(DataRow row in datatable.Rows)

                {
                    app_id = Int32.Parse(row["app_id"].ToString());
                    url = row["url"].ToString();
                    icon = row["icon"].ToString();
                    screenshot = row["screenshot"].ToString();

                    app_name = row["app_name"].ToString();
                    browser = row["browser"].ToString();

                    ApplicationModel app = new ApplicationModel(app_id, url, icon, screenshot, status, app_name, browser);

                    last3application.Add(app);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
                conn.Close();
                
            }


            return last3application;

        }



        public List<ApplicationModel> getAppGroups(int userId)
        {
            DataTable datatable = new DataTable();
            OracleConnection conn = db.initializare();

            List<ApplicationModel> applicationsgr = new List<ApplicationModel>();
            int app_id;
            string url;
            string icon;
            string screenshot;
            int status = 1;
            string app_name;
            string browser;


            try
            {
                command = new OracleCommand(Query.appgrups, conn);
                command.Parameters.Add(new OracleParameter("userid", userId));

                adapter = new OracleDataAdapter(command);
                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)

                {
                    app_id = Int32.Parse(row["app_id"].ToString());
                    url = row["url"].ToString();
                    icon = row["icon"].ToString();
                    screenshot = row["screenshot"].ToString();

                    app_name = row["app_name"].ToString();
                    browser = row["browser"].ToString();

                    ApplicationModel app = new ApplicationModel(app_id, url, icon, screenshot, status, app_name, browser);

                    applicationsgr.Add(app);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                conn.Close();

            }


            return applicationsgr;

        }




    }
}