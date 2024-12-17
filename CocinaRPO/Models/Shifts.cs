using System.ComponentModel.DataAnnotations;

namespace CocinaRPO.Models
{
    public class Shifts
    {
        [Key]
        public int ShiftId { get; set; }
        public int CookId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // ForenKey
        public Cooks? Cooks { get; set; }

    }
}
