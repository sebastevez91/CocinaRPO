using System.ComponentModel.DataAnnotations;

namespace CocinaRPO.Models
{
    public class Notices
    {
        [Key]
        public int NoticeId { get; set; }
        public int ShiftId { get; set; }
        public int CookId { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime NoticeDate { get; set; }

        // ForenKey
        public Cooks? Cooks { get; set; }
        public Shifts? Shifts { get; set; }
    }
}
