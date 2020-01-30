using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BasicAuthentication.Models;

namespace BasicAuthentication
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (SampleDBContext db = new SampleDBContext())
            {
                return db.Users.Any(x => x.Username.Equals(username,StringComparison.OrdinalIgnoreCase) && x.Password == password);
            }
        }
    }
}