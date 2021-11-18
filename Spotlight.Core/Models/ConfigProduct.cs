using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigProduct
    {
        public int ProductId { get; set; }
        public int PropertyId { get; set; }
        public int? ProductTypeId { get; set; }
        public string ConnectionString { get; set; }
        public int? SsispackageRoute { get; set; }
    }
}
