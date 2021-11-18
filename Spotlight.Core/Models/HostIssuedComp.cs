using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostIssuedComp
    {
        public long HostIssuedCompId { get; set; }
        public string Commment { get; set; }
        public decimal CompensationAmmount { get; set; }
        public DateTime DateTimeIssued { get; set; }
        public int HostUserId { get; set; }
        public string PatronId { get; set; }
        public int PropertyId { get; set; }
    }
}
