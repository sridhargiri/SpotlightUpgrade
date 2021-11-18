using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostTaskManager
    {
        public HostTaskManager()
        {
            HostTaskAssigneds = new HashSet<HostTaskAssigned>();
            HostTaskAutoGenerators = new HashSet<HostTaskAutoGenerator>();
            HostTaskHosts = new HashSet<HostTaskHost>();
            HostTaskPatrons = new HashSet<HostTaskPatron>();
        }

        public long HostTaskKey { get; set; }
        public string HostTaskDescription { get; set; }
        public string HostTaskStatus { get; set; }
        public DateTime HostTaskStartDate { get; set; }
        public DateTime HostTaskEndDate { get; set; }
        public int? ContactTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool ProcessingFlag { get; set; }
        public int PropertyId { get; set; }
        public int? HostTaskCategoryId { get; set; }
        public bool? Preview { get; set; }
        public bool AutoHost { get; set; }
        public bool Archived { get; set; }

        public virtual ContactType ContactType { get; set; }
        public virtual HostTaskCategory HostTaskCategory { get; set; }
        public virtual ICollection<HostTaskAssigned> HostTaskAssigneds { get; set; }
        public virtual ICollection<HostTaskAutoGenerator> HostTaskAutoGenerators { get; set; }
        public virtual ICollection<HostTaskHost> HostTaskHosts { get; set; }
        public virtual ICollection<HostTaskPatron> HostTaskPatrons { get; set; }
    }
}
