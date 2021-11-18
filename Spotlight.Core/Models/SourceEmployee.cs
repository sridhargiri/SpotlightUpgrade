using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceEmployee
    {
        public long RecId { get; set; }
        public int PropertyFk { get; set; }
        public int EmployeeBk { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string NameSuffix { get; set; }
        public string Initials { get; set; }
        public string UserName { get; set; }
        public string EmployeeNumber { get; set; }
        public long? Crc { get; set; }
        public bool? Active { get; set; }
    }
}
