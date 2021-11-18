using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ContactLog
    {
        public int ContactLogId { get; set; }
        public int PropertyId { get; set; }
        public string PatronId { get; set; }
        public int? PatronHostId { get; set; }
        public int ContactHostId { get; set; }
        public int ContactTypeId { get; set; }
        public string ContactNotes { get; set; }
        public string AttachmentUrl { get; set; }
        public DateTime ContactDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? DeletedByUser { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedByUser { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
