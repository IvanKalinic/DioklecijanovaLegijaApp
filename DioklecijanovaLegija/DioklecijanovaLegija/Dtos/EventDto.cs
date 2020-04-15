using System;
using System.ComponentModel.DataAnnotations;

namespace DioklecijanovaLegija.Dtos
{
    public class EventDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public DateTime? DateOfEvent { get; set; }

        [Required]
        public int NumberOfMembers { get; set; }

        public string Location { get; set; }
    }
}
