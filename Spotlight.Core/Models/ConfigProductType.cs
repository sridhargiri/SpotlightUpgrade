using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigProductType
    {
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }
        public string Activity { get; set; }
        public string IconName { get; set; }
        public string Label { get; set; }
        public string CssClass { get; set; }
    }
}
