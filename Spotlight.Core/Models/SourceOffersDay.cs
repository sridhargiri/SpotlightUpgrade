using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceOffersDay
    {
        public int PropertyId { get; set; }
        public int PatronId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string HasSubscribed { get; set; }
        public string HasRefused { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}
