using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SurveillanceAlert
    {
        public long RecId { get; set; }
        public string PlayerBk { get; set; }
        public string UniversalId { get; set; }
        public string Comments { get; set; }
    }
}
