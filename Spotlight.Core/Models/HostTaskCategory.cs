using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostTaskCategory
    {
        public HostTaskCategory()
        {
            HostTaskManagers = new HashSet<HostTaskManager>();
        }

        public int HostTaskCategoryKey { get; set; }
        public string Category { get; set; }
        public string CategoryDescription { get; set; }
        public bool UserDefined { get; set; }
        public bool AddToCalendar { get; set; }
        public string IconName { get; set; }
        public string Label { get; set; }
        public string CssClass { get; set; }

        public virtual ICollection<HostTaskManager> HostTaskManagers { get; set; }
    }
}
