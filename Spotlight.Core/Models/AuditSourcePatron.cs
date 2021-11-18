using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class AuditSourcePatron
    {
        public int AuditKey { get; set; }
        public bool AllowCall { get; set; }
        public string CellPhone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string NickName { get; set; }
        public string PlayerBk { get; set; }
        public int PropertyId { get; set; }
        public short RecordType { get; set; }
        public string State { get; set; }
        public string StreetAddress2 { get; set; }
        public string StreetAddress1 { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int UserId { get; set; }
        public string ZipCode { get; set; }
        public bool AllowMail { get; set; }
        public string Ethnicity { get; set; }
        public bool BadAddress { get; set; }
        public bool Seasonal { get; set; }
    }
}
