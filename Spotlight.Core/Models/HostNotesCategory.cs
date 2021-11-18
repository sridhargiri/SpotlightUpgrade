using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostNotesCategory
    {
        public HostNotesCategory()
        {
            HostNote1s = new HashSet<HostNote1>();
        }

        public int NoteCategoryId { get; set; }
        public string NotesCategoryDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public int? ArchivedBy { get; set; }
        public DateTime? ArchivedDateTime { get; set; }
        public bool IsArchived { get; set; }
        public bool IsSystem { get; set; }

        public virtual ICollection<HostNote1> HostNote1s { get; set; }
    }
}
