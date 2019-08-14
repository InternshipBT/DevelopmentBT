using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternshipAPI.Repository
{
    public class Query
    {
        public static string allusers = "from users";
        public static string favApps = "select app_id,url,icon,screenshot,app_name,browser " +
            "from vw_favapp where user_id =:user_id";
       public static string las3app = "select app_id,url,icon,screenshot,app_name,browser " +
            "from vw_last3app where user_id =:user_id";
        public static string appgrups = "select app_id,url,icon,screenshot,app_name,browser " +
            "from vw_appsgroups where user_id =:user_id";
    }
}