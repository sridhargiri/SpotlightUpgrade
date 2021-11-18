using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostEnrolled
    {
        public long HostEnrolledId { get; set; }
        public int PropertyId { get; set; }
        public int HostUserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string IdNumber { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateTimeEnrolled { get; set; }
    }
}
