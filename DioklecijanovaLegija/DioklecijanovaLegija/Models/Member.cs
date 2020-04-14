using System;
using System.ComponentModel.DataAnnotations;

namespace DioklecijanovaLegija.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int NumberOfAllowedShifts { get; set; }

        [Display(Name = "Soldier type: ")]
        public byte SoldierTypeId { get; set; }

        public SoldierType SoldierType { get; set; }
    }
}
