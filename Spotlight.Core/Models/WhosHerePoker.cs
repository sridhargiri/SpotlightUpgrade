using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class WhosHerePoker
    {
        public int WhosHereId { get; set; }
        public int PropertyId { get; set; }
        public int? RatingId { get; set; }
        public string PlayerId { get; set; }
        public string PlayerName { get; set; }
        public byte? PlayerActive { get; set; }
        public string PlayerCardLevel { get; set; }
        public string Pit { get; set; }
        public string TableId { get; set; }
        public string TablePosition { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? _24hourTimePlayed { get; set; }
        public decimal? _24hourTotalIn { get; set; }
        public decimal? _24hourTotalOut { get; set; }
        public decimal? _24hourTheoWin { get; set; }
        public decimal? _24hourActualWin { get; set; }
        public DateTime? _24hourLastUpdate { get; set; }
        public int? HostUserId { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public DateTime? AlertWhosHereDateTime { get; set; }
        public DateTime? AlertContactDateTime { get; set; }
        public DateTime? AlertJackpotDateTime { get; set; }
        public DateTime? AlertThresholdDateTime { get; set; }
        public byte? JackpotFlag { get; set; }
        public decimal? JackpotAmount { get; set; }
        public int? AlertType { get; set; }
        public string UniversalId { get; set; }
    }
}
