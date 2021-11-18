using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class EmailAlert
    {
        public int AlertId { get; set; }
        public int AlertTypeId { get; set; }
        public int? WhosHereId { get; set; }
        public int? PropertyId { get; set; }
        public string PlayerId { get; set; }
        public string UniversalId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerCardLevel { get; set; }
        public int? HostUserId { get; set; }
        public string HostFullName { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public string Asset { get; set; }
        public string Pit { get; set; }
        public string TableId { get; set; }
        public string TablePosition { get; set; }
        public DateTime? LastActivity { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public decimal? Adt { get; set; }
        public decimal? TheoWin { get; set; }
        public decimal? WinLoss { get; set; }
        public decimal? JackpotAmount { get; set; }
        public DateTime? LastContactDate { get; set; }
        public string LastContactDateText { get; set; }
        public int? DaysSinceLastContact { get; set; }
        public decimal? _24hourCashIn { get; set; }
        public decimal? _24hourActualWin { get; set; }
        public decimal? _24hourTheoWin { get; set; }
        public decimal? TotalBuyIn { get; set; }
        public int? BufferId { get; set; }
        public DateTime? GamingDate { get; set; }
        public DateTime? AlertSentTimestamp { get; set; }
        public string AlertSent { get; set; }
    }
}
