using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigProperty
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public string Property { get; set; }
        public string PlayersClubEmail { get; set; }
        public decimal? SlotCoinInThreshold { get; set; }
        public string SlotCoinInFlag { get; set; }
        public decimal? SlotActualWinThreshold { get; set; }
        public string SlotActualWinFlag { get; set; }
        public decimal? SlotTheoWinThreshold { get; set; }
        public string SlotTheoWinFlag { get; set; }
        public decimal? PitCoinInThreshold { get; set; }
        public string PitCoinInFlag { get; set; }
        public decimal? PitActualWinThreshold { get; set; }
        public string PitActualWinFlag { get; set; }
        public decimal? PitTheoWinThreshold { get; set; }
        public string PitTheoWinFlag { get; set; }
        public string BaseClubLevel { get; set; }
        public string Online { get; set; }
        public string HasHosts { get; set; }
        public DateTime? LastGamingDate { get; set; }
        public string DomainName { get; set; }
        public string HostManagerEmail { get; set; }
        public int ExpireReferral { get; set; }
        public int ExpireHost { get; set; }
        public string ExpireReferralUnit { get; set; }
        public string ExpireHostUnit { get; set; }
        public decimal? SlotJackpotThreshold { get; set; }
        public bool SlotJackpotFlag { get; set; }
        public decimal? PitJackpotThreshold { get; set; }
        public bool PitJackpotFlag { get; set; }
        public string TimeRemove { get; set; }
        public int? Adtdays { get; set; }
        public int? Adttype { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string FormattedAddress { get; set; }
        public bool? AllowComps { get; set; }
        public string EmailCompTo { get; set; }
        public decimal MaxComp { get; set; }
        public bool AllowEnrollment { get; set; }
        public string EmailEnrollmentTo { get; set; }
        public string HostSelectString { get; set; }
        public int? GamingDateHour { get; set; }
        public int? GamingDateMinute { get; set; }
        public string Xmlpath { get; set; }
        public bool EthnicityUsed { get; set; }
        public bool ShowTierStatus { get; set; }
        public int MinimumAge { get; set; }
        public bool StatsIncTax { get; set; }
        public double StatsTaxPercent { get; set; }
        public bool StatsApplyToWinOnly { get; set; }
        public bool StatsIncCompAdjust { get; set; }
        public bool StatsIncDollarsAdjust { get; set; }
        public bool StatsIncTaxInReinvest { get; set; }
        public string Top20DefaultSort { get; set; }
        public string NewSignupDefaultSort { get; set; }
        public decimal MaxCompWeekly { get; set; }
        public decimal MaxCompMonthly { get; set; }
        public bool AllowAutoTask { get; set; }
        public string Version { get; set; }
        public bool WriteCompNotes { get; set; }
        public int CompNoteCategoryId { get; set; }
        public bool WriteCompContactLog { get; set; }
        public int CompContactLogCategoryId { get; set; }
        public string CompTextLineMemo { get; set; }
        public string MaxCompApplyTo { get; set; }
        public double CompWarningPercent { get; set; }
        public short CompStartDayOfWeek { get; set; }
        public bool ShowSlotAvBet { get; set; }
        public bool ShowTableAvBet { get; set; }
        public bool AllowSuggestedReferrals { get; set; }
        public bool? EnableGeolocationFeature { get; set; }
        public bool ShowSlotStatsNetTheo { get; set; }
        public bool ShowTableStatsNetTheo { get; set; }
        public bool ShowTheoNetOfFreePlay { get; set; }
        public string AreaDescription { get; set; }
        public string SectionDescription { get; set; }
        public bool? SearchResultPatronId { get; set; }
        public bool? SearchResultName { get; set; }
        public bool? SearchResultEmail { get; set; }
        public bool? SearchResultAddress { get; set; }
        public bool? SearchResultGender { get; set; }
        public bool? SearchResultEthnicity { get; set; }
        public bool? SearchResultHost { get; set; }
        public bool? SearchResultCardLevel { get; set; }
        public bool? SearchResultStatus { get; set; }
        public string RibbonStats { get; set; }
        public bool ShowAverageFiveTripTheo { get; set; }
        public string BannedPlayerText { get; set; }
    }
}
