using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Employee
    {
        public int? PropertyId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string UserAd { get; set; }
        public string Administrator { get; set; }
    }
}
