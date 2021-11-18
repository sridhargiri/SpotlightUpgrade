using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Dapuser
    {
        public int RecId { get; set; }
        public int? UserId { get; set; }
        public string EmailAddress { get; set; }
    }
}
