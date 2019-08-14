using InternshipAPI.Models;
using InternshipAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternshipAPI.Services
{
    public class ApplicationService
    {
        public static  List<ApplicationModel> getFavApps(int userId)
        {
            ApplicationRepository apprepository = new ApplicationRepository();
            List<ApplicationModel> fav = apprepository.getFavApps(userId);
            return fav;
            
            
        }

        public static List<ApplicationModel> getLast3Apps(int userId)
        {
            ApplicationRepository apprepository = new ApplicationRepository();
            List<ApplicationModel> last3appliction = apprepository.getLast3App(userId);
            return last3appliction;
        }


        public static List<ApplicationModel> getAppGroups(int userId)
        {
            ApplicationRepository apprepository = new ApplicationRepository();
            List<ApplicationModel> applicationsgr = apprepository.getAppGroups(userId);
            return applicationsgr;
        }
    }
}