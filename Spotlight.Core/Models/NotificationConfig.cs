using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class NotificationConfig
    {
        public int? PropertyId { get; set; }
        public string ProcessName { get; set; }
        public bool? Htmlenabled { get; set; }
        public string EmailHeaderCasinoName { get; set; }
        public bool? ProcessEnabled { get; set; }
        public string ProfileName { get; set; }
    }
}
