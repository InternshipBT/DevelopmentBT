using InternshipAPI.Repository;
using InternshipAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;


namespace InternshipAPI.Controllers
{
    public class ApplicationController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/getFavApp")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public IHttpActionResult GetFirst(int userId)
        {
            return Ok(ApplicationService.getFavApps(userId));
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/getLast3App")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public IHttpActionResult GetLast3 (int userId)
        {
            return Ok(ApplicationService.getLast3Apps(userId));
        }



        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/getAppGroups")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public IHttpActionResult AppsGr(int userId)
        {
            return Ok(ApplicationService.getAppGroups(userId));
        }
    }
}