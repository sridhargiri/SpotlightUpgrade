using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Host1 : IUser<int>
    {
        public Host1()
        {
            HostRoles = new HashSet<HostRole>();
            HostTaskAssigneds = new HashSet<HostTaskAssigned>();
            HostTaskHosts = new HashSet<HostTaskHost>();
        }


        public int Id { get; set; }

        public string UserName { get; set; }
        public int HostsId { get; set; }
        public int? PropertyId { get; set; }
        public int HostUserId { get; set; }
        public string HostUserName { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public string HostPassword { get; set; }
        public DateTime? LastLogin { get; set; }
        public string AllHostsFlag { get; set; }
        public string Sqlsearch { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? DeletedUserId { get; set; }
        public string HostEmail { get; set; }
        public string SendAlerts { get; set; }
        public string ActiveFlag { get; set; }
        public DateTime? LastPasswordChange { get; set; }
        public string TemporaryPassword { get; set; }
        public string AllowSelect { get; set; }
        public string Administrator { get; set; }
        public bool GamingRevenueFlag { get; set; }
        public bool ReinvestmentFlag { get; set; }
        public bool WorthFlag { get; set; }
        public bool ReinvesmentPercentFlag { get; set; }
        public bool? PointsFlag { get; set; }
        public bool? CompDollarsFlag { get; set; }
        public bool? Adtflag { get; set; }
        public bool? TripsLast90Flag { get; set; }
        public bool? TheoYesterdayFlag { get; set; }
        public bool? TheoTodayFlag { get; set; }
        public bool? LastVisitFlag { get; set; }
        public bool? TripsThisYearFlag { get; set; }
        public string SystemAdministrator { get; set; }
        public string ChangeHostFlag { get; set; }
        public string ChangeReferralFlag { get; set; }
        public bool SendContactAlerts { get; set; }
        public bool SendJackpotAlerts { get; set; }
        public bool SendThresholdAlerts { get; set; }
        public long Crc { get; set; }
        public bool? AllowLogin { get; set; }
        public short StatsType { get; set; }
        public bool AllowComps { get; set; }
        public bool AllowEnrollment { get; set; }
        public bool AllowPatronEmail { get; set; }
        public bool FreePlayBalanceFlag { get; set; }
        public bool SendBirthdayAlerts { get; set; }
        public bool SendBannedAlerts { get; set; }
        public bool SendTitle31Alerts { get; set; }
        public string LdapuserName { get; set; }
        public bool SendVvipalerts { get; set; }
        public bool SendServiceAlerts { get; set; }
        public bool Send2ndVisitAlerts { get; set; }
        public bool SuggestedReferralAlerts { get; set; }
        public bool AllowTaskAssign { get; set; }

        public virtual ICollection<HostRole> HostRoles { get; set; }
        public virtual ICollection<HostTaskAssigned> HostTaskAssigneds { get; set; }
        public virtual ICollection<HostTaskHost> HostTaskHosts { get; set; }
    }
}
