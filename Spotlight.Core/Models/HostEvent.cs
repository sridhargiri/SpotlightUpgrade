using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostEvent
    {
        public int EventId { get; set; }
        public int? HostUserId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public byte? CallFlag { get; set; }
        public byte? EmailFlag { get; set; }
        public byte? MailFlag { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public string EventDescription { get; set; }
        public DateTime? DateTimeEntered { get; set; }
        public int HostEntered { get; set; }
        public DateTime? DateTimeCompleted { get; set; }
        public int? HostCompleted { get; set; }
        public DateTime? DateTimeDeleted { get; set; }
        public int? HostDeleted { get; set; }
        public DateTime? DateTimeReminderSet { get; set; }
        public int? HostReminderSet { get; set; }
        public DateTime? DateTimeReminderRemoved { get; set; }
        public int? HostReminderRemoved { get; set; }
        public DateTime? DateTimeLastUpdated { get; set; }
        public int? HostLastUpdated { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime? ReminderEndDateTime { get; set; }
        public bool IsLocked { get; set; }
    }
}
