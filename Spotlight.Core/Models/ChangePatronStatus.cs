using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ChangePatronStatus
    {
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string Status { get; set; }
    }
}
