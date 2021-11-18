using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class DailyRoisummary
    {
        public long DailyRoisummaryId { get; set; }
        public int PropertyId { get; set; }
        public string PatronId { get; set; }
        public string PatronName { get; set; }
        public string LastName { get; set; }
        public string CardLevel { get; set; }
        public DateTime? FirstContactMade { get; set; }
        public DateTime? LastContactMade { get; set; }
        public int? Contacts { get; set; }
        public int? DaysBetween { get; set; }
        public DateTime? LastVisit { get; set; }
        public int? TripsBefore { get; set; }
        public int? TripsAfter { get; set; }
        public int? TripsIncrease { get; set; }
        public decimal? TotalTheoBefore { get; set; }
        public decimal? TotalTheoAfter { get; set; }
        public decimal? TotalTheoIncrease { get; set; }
        public decimal? Adtbefore { get; set; }
        public decimal? Adtafter { get; set; }
        public decimal? Adtincrease { get; set; }
        public decimal? TotalActualBefore { get; set; }
        public decimal? TotalActualAfter { get; set; }
        public decimal? TotalActualIncrease { get; set; }
        public decimal? Adabefore { get; set; }
        public decimal? Adaafter { get; set; }
        public decimal? Adaincrease { get; set; }
    }
}
