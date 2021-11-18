using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportUserFavorite
    {
        public long ReportUserFavoriteId { get; set; }
        public long ReportUserId { get; set; }
        public long ReportMasterId { get; set; }
    }
}
