using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatron
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthDay { get; set; }
        public int? BirthYear { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public string HomePhone { get; set; }
        public string AlternativePhone { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public int? AnniversaryMonth { get; set; }
        public int? AnniversaryDay { get; set; }
        public int? AnniversaryYear { get; set; }
        public DateTime? WeddingAnniversaryDate { get; set; }
        public int? WeddingAnniversaryMonth { get; set; }
        public int? WeddingAnniversaryDay { get; set; }
        public int? WeddingAnniversaryYear { get; set; }
        public string Referral { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string Banned { get; set; }
        public string StatusId { get; set; }
        public string Status { get; set; }
        public string CustomFlag1 { get; set; }
        public string CustomFlag2 { get; set; }
        public string CustomFlag3 { get; set; }
        public string CustomFlag4 { get; set; }
        public string CustomFlag5 { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
        public bool? AllowMail { get; set; }
        public bool? AllowCall { get; set; }
        public bool? BadAddress { get; set; }
        public bool? Seasonal { get; set; }
        public string UniversalId { get; set; }
        public long? Crc { get; set; }
    }
}
