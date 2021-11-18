using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostNoContact
    {
        public string PlayerId { get; set; }
        public int PropertyId { get; set; }
        public int? HostUserId { get; set; }
        public int? ReferralHostUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LastContact { get; set; }
        public int? ContactDays { get; set; }
        public DateTime? LastVisit { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string CardLevel { get; set; }
        public string Homephone { get; set; }
        public string EmailAddress { get; set; }
        public string AlternativePhone { get; set; }
        public string Banned { get; set; }
        public string Status { get; set; }
    }
}
