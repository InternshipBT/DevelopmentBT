using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternshipAPI.Models
{
    public class ApplicationModel
    {
        public int app_id;
        public string url;
        public string icon;
        public string screenshot;
        public int status;
        public string app_name;
        public string browser;

        public ApplicationModel() { 
}
        public ApplicationModel(int app_id, string url, string icon, string screenshot, int status, string app_name, string browser)
        {
            this.app_id = app_id;
            this.app_name = app_name;
            this.url = url;
            this.icon = icon;
            this.screenshot = screenshot;
            this.status = status;
            this.browser = browser;

        }
    }
}