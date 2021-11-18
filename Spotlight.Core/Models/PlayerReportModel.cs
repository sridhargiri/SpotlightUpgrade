using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight.Core.Models
{
    public partial class PlayerReportModel
    {
        public int PlayerId { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HostName { get; set; }
        public string PlayerType { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public bool AllowMail { get; set; }
        public string Tier { get; set; }
        public string Phone { get; set; }
        public string AlternativePhone { get; set; }
        public string EmailAddress { get; set; }
        public string Status { get; set; }
        public string Seasonal { get; set; }
        public int? Prop90Tips { get; set; }
        public decimal? Prop90ADT { get; set; }
        public decimal? Prop90ADA { get; set; }
        public string Frequency { get; set; }
        public string FavoriteActivity { get; set; }
        public string FavoriteGame { get; set; }
        public DateTime? PatronHostLastContact { get; set; }
        public DateTime? OtherLastContact { get; set; }
        public string OtherContactHost { get; set; }
        public DateTime? LastVisit { get; set; }
        public int? LengthHostString { get; set; }
        public string FrequencyColor { get; set; }
    }
}
