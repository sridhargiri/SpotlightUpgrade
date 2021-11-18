using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigCardLevel
    {
        public long CardLevelKey { get; set; }
        public string CardLevelName { get; set; }
        public int CardLevelSequence { get; set; }
        public string CardLevelColor { get; set; }
        public string BgcardLevelColor { get; set; }
        public string CardLevelTextColor { get; set; }
        public double CardLevelThreshold { get; set; }
        public DateTime? CardLevelStartDate { get; set; }
        public DateTime? CardLevelEndDate { get; set; }
        public bool? DisplayVvipicon { get; set; }
        public int PulsateIconHours { get; set; }
    }
}
