using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BasicAuthentication.Models;
using BasicAuthentication.ViewModels;
using System.Threading;

namespace BasicAuthentication.Controllers
{
    public class EmployeeController : ApiController
    {
    
        [BasicAuthentication]
        [HttpGet]
        public HttpResponseMessage LoadAllEmployee()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            using (SampleDBContext db = new SampleDBContext())
            {
               
                switch (username.ToLower())
                {
                    case "male":
                        return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(x => x.Gender.ToLower() == "male").Select(x => new EmployeeVM()
                        {
                            FirstName = x.FirstName,
                            LastName = x.LastName,
                            Gender = x.Gender,
                            Salary = x.Salary,
                        }).ToList());
                    case "female":
                        return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(x => x.Gender.ToLower() == "female").Select(x => new EmployeeVM()
                        {
                            FirstName = x.FirstName,
                            LastName = x.LastName,
                            Gender = x.Gender,
                            Salary = x.Salary,
                        }).ToList());

                    default:
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
        }
    }
}



//string username = Thread.CurrentPrincipal.Identity.Name;
//                switch (username.ToLower())
//                {
//                    case "male":
//                        return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(x => x.Gender.ToLower() == "male").Select(x => new EmployeeVM()
//{
//    FirstName = x.FirstName,
//                            LastName = x.LastName,
//                            Gender = x.Gender,
//                            Salary = x.Salary,
//                        }).ToList());
//                    case "female":
//                        return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(x => x.Gender.ToLower() == "female").Select(x => new EmployeeVM()
//{
//    FirstName = x.FirstName,
//                            LastName = x.LastName,
//                            Gender = x.Gender,
//                            Salary = x.Salary,
//                        }).ToList());
//                    case "default":
//                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "username and password is not correct");
//                }