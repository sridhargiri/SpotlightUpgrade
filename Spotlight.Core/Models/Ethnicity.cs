using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Ethnicity
    {
        public int EthnicityId { get; set; }
        public string Name { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public int? ArchivedBy { get; set; }
        public DateTime? ArchivedDateTime { get; set; }
        public bool IsArchived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
