using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronLifecycle
    {
        public long PatronLifecycleId { get; set; }
        public int HostUserId { get; set; }
        public string HostName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string Frequency { get; set; }
        public string FrequencyColor { get; set; }
        public string CardLevel { get; set; }
        public DateTime? FirstDayOfPlay { get; set; }
        public DateTime? LastDayOfPlay { get; set; }
        public int? PointsEarned { get; set; }
        public int? CurrentTierPointsRequired { get; set; }
        public int? NextTierPointsRequired { get; set; }
        public decimal? CoinIn { get; set; }
        public decimal? ActualWin { get; set; }
        public decimal? TheoWin { get; set; }
        public int? Visits { get; set; }
        public double? Adt { get; set; }
        public double? Ada { get; set; }
        public int? PreviousCardLevelSequence { get; set; }
        public string PreviousCardLevel { get; set; }
        public double? PreviousCardLevelThreshold { get; set; }
        public int? CurrentCardLevelSequence { get; set; }
        public string CurrentCardLevel { get; set; }
        public double? CurrentCardLevelThreshold { get; set; }
        public int? NextCardLevelSequence { get; set; }
        public string NextCardLevel { get; set; }
        public double? NextCardLevelThreshold { get; set; }
        public DateTime? ChangeDate { get; set; }
        public long? Crc { get; set; }
    }
}
