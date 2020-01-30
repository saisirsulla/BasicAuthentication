using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.ViewModels
{
    public class DepartmentVM
    {
        

        public int id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Nullable<bool> isSelected { get; set; }


    }
}