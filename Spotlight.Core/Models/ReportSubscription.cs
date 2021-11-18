using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportSubscription
    {
        public long ReportSubscriptionId { get; set; }
        public long ReportUserId { get; set; }
        public long ReportMasterId { get; set; }
        public string FrequencyOccurs { get; set; }
        public short? HourlyStartTime { get; set; }
        public short? HourlyEndTime { get; set; }
        public bool? DayOfWeekSun { get; set; }
        public bool? DayOfWeekMon { get; set; }
        public bool? DayOfWeekTue { get; set; }
        public bool? DayOfWeekWed { get; set; }
        public bool? DayOfWeekThu { get; set; }
        public bool? DayOfWeekFri { get; set; }
        public bool? DayOfWeekSat { get; set; }
        public short? DayOfWeekRunTime { get; set; }
        public short? DayOfMonth { get; set; }
        public short? DateOfMonth { get; set; }
        public short? DayOfMonthRunTime { get; set; }
        public string EmailAddress { get; set; }
        public string EmailMessage { get; set; }
        public bool? ExportToPdf { get; set; }
        public bool? ExportToExcel { get; set; }
        public bool? ExportToWord { get; set; }
    }
}
