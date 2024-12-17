using System.ComponentModel.DataAnnotations;

namespace CocinaRPO.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        public int CookId { get; set; }
        public int ShiftId { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }

        // ForenKey
        public Cooks? Cooks { get; set; }
        public Shifts? Shifts { get; set; }
    }
}
