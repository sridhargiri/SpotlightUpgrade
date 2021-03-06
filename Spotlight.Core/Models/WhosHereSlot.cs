using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class WhosHereSlot
    {
        public int WhosHereId { get; set; }
        public int? PropertyId { get; set; }
        public int? BufferId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? TransactionCode { get; set; }
        public string TransactionDescription { get; set; }
        public string PlayerId { get; set; }
        public byte? PlayerActive { get; set; }
        public string PlayerCardLevel { get; set; }
        public string Asset { get; set; }
        public string CasinoId { get; set; }
        public string AreaId { get; set; }
        public string SectionId { get; set; }
        public string LocationId { get; set; }
        public string Location { get; set; }
        public string Game { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? _24hourTimePlayed { get; set; }
        public decimal? _24hourCashIn { get; set; }
        public decimal? _24hourCashOut { get; set; }
        public decimal? _24hourJackpot { get; set; }
        public decimal? _24hourTheoWin { get; set; }
        public decimal? _24hourActualWin { get; set; }
        public DateTime? _24hourLastUpdate { get; set; }
        public byte? JackpotFlag { get; set; }
        public decimal? JackpotAmount { get; set; }
    }
}
