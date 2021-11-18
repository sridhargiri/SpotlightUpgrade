using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class WhosHereHotel1
    {
        public int WhosHereId { get; set; }
        public int PropertyId { get; set; }
        public string ReservationId { get; set; }
        public string ConfirmationNo { get; set; }
        public string PlayerId { get; set; }
        public string PlayerName { get; set; }
        public byte? PlayerActive { get; set; }
        public string PlayerCardLevel { get; set; }
        public string Hotel { get; set; }
        public string RoomId { get; set; }
        public string ReservationStatus { get; set; }
        public DateTime? ReservationCheckInDate { get; set; }
        public DateTime? ReservationCheckOutDate { get; set; }
        public DateTime? ActualCheckInDate { get; set; }
        public DateTime? ActualCheckOutDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? HostUserId { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public int? AlertType { get; set; }
        public short HostType { get; set; }
        public short? VisitNumber { get; set; }
        public string PatronId { get; set; }
        public string Activity { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }

        public virtual SourcePatron1 P { get; set; }
    }
}
