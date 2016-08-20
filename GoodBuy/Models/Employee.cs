using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodBuy.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Hired")]
        public DateTime HireDate { get; set; }
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
    }
}