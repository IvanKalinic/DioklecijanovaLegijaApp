using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DioklecijanovaLegija.Models
{
    public class Member
    {
        public Member()
        {
            this.Events = new HashSet<Event>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Date of birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int NumberOfAllowedShifts { get; set; }

        [Display(Name = "Soldier type: ")]
        public byte SoldierTypeId { get; set; }

        public SoldierType SoldierType { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
