using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class EmployeeClass:PersonClass
    {
        public string NationalCode { get; set; }
        public int EmployeeId { get; set; }
        public DateTime EmployeementDate { get; set; }
    }
}
