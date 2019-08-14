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
    public class HelloWorldController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Hello")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]


        public IHttpActionResult GetFirst(string name)
        {
            return Ok(HelloWorldService.Hello(name));
        }
    }
}