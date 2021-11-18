using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatron1
    {
        public SourcePatron1()
        {
            HostTaskPatrons = new HashSet<HostTaskPatron>();
            WhosHereHotel1s = new HashSet<WhosHereHotel1>();
        }

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
        public int? HostUserId { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public int? ReferralHostUserId { get; set; }
        public string ReferralHostFirstName { get; set; }
        public string ReferralHostLastName { get; set; }
        public string Referral { get; set; }
        public string CardLevel { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public int? PointsBalance { get; set; }
        public decimal? DollarsBalance { get; set; }
        public decimal FreePlayBalance { get; set; }
        public DateTime? LastVisit { get; set; }
        public decimal? Adt { get; set; }
        public decimal? TheoWinYesterday { get; set; }
        public decimal? TheoWinToday { get; set; }
        public decimal? ActualWinYesterday { get; set; }
        public decimal? ActualWinToday { get; set; }
        public int? TripsThisYear { get; set; }
        public int? TripsLast90 { get; set; }
        public string Banned { get; set; }
        public string StatusId { get; set; }
        public string Status { get; set; }
        public string CustomFlag1 { get; set; }
        public string CustomFlag2 { get; set; }
        public string CustomFlag3 { get; set; }
        public string CustomFlag4 { get; set; }
        public string CustomFlag5 { get; set; }
        public bool AllowMail { get; set; }
        public bool AllowCall { get; set; }
        public DateTime? DateTimeAdded { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
        public string UpdateFlag { get; set; }
        public string Used { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string FormattedAddress { get; set; }
        public long? Crc { get; set; }
        public string FavoriteActivity { get; set; }
        public string FavoriteGame { get; set; }
        public string FavoriteLocation { get; set; }
        public double? NextTier { get; set; }
        public string Frequency { get; set; }
        public string FrequencyColor { get; set; }
        public decimal Ada { get; set; }
        public DateTime? LastContact { get; set; }
        public string MergedAccount { get; set; }
        public bool BadAddress { get; set; }
        public bool Seasonal { get; set; }
        public float Average5TripTheo { get; set; }
        public string BannedMessageText { get; set; }
        public string UniversalId { get; set; }

        public virtual ICollection<HostTaskPatron> HostTaskPatrons { get; set; }
        public virtual ICollection<WhosHereHotel1> WhosHereHotel1s { get; set; }
    }
}
