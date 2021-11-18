using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            ContactLogs = new HashSet<ContactLog>();
            HostTaskManagers = new HashSet<HostTaskManager>();
        }

        public int ContactTypeId { get; set; }
        public string ContactType1 { get; set; }
        public bool IsDefault { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public int? ArchivedBy { get; set; }
        public DateTime? ArchivedDateTime { get; set; }
        public bool IsArchived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool AllowTaskManager { get; set; }
        public bool? AllowContactLog { get; set; }
        public bool? IsEmail { get; set; }
        public bool AllowTaskToWriteContact { get; set; }
        public int TaskNoteCategory { get; set; }

        public virtual ICollection<ContactLog> ContactLogs { get; set; }
        public virtual ICollection<HostTaskManager> HostTaskManagers { get; set; }
    }
}
