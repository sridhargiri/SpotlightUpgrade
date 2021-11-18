using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronFavorite
    {
        public long RecId { get; set; }
        public string FavoriteActivity { get; set; }
        public string FavoriteGame { get; set; }
        public string FavoriteLocation { get; set; }
    }
}
