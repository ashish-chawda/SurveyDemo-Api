using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using survey_demo_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace survey_demo_api.Controllers
{
    public class RoleController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllRoles")]
        
        public HttpResponseMessage GetRoles()
        {
            var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var roles = roleManager.Roles.
                Select(r => new { r.Id, r.Name }).ToList();

            return this.Request.CreateResponse(HttpStatusCode.OK, roles);
        }
    }
}
