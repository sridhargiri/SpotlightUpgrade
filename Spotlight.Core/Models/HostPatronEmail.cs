using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostPatronEmail
    {
        public long EmailKey { get; set; }
        public int FromHostUserId { get; set; }
        public int ToPatronId { get; set; }
        public string FromHostEmailAddress { get; set; }
        public string ToPatronEmailAddress { get; set; }
        public string EmailSubject { get; set; }
        public string EmailMessage { get; set; }
        public DateTime DateTimeSubmitted { get; set; }
        public DateTime? DateTimeSent { get; set; }
        public int PropertyId { get; set; }
    }
}
