using System;

namespace DioklecijanovaLegija.Models
{
    public class Calendar
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string ThemeColor { get; set; }

        public bool IsFullDay { get; set; }

    }
}
