using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronBanned
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
