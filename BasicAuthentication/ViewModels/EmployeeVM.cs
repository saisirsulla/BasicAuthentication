using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.ViewModels
{
    public class EmployeeVM
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Nullable<int> Department_id { get; set; }

       
    }
}