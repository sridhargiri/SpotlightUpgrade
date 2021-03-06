using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ChangePatronTripCount
    {
        public long RecId { get; set; }
        public int? GamingTrips { get; set; }
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }
        public long Crc { get; set; }
    }
}
