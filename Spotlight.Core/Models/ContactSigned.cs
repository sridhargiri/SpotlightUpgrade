using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ContactSigned
    {
        public int PropertyId { get; set; }
        public int ContactHostId { get; set; }
        public string ContactHostName { get; set; }
        public string PatronId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ContactDateTime { get; set; }
        public int ContactTypeId { get; set; }
        public string ContactType { get; set; }
        public string ContactNotes { get; set; }
        public string Signed { get; set; }
        public string OtherHostName { get; set; }
        public int SignId { get; set; }
    }
}
