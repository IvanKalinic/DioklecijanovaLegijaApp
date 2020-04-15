using System;
using System.ComponentModel.DataAnnotations;

namespace DioklecijanovaLegija.Dtos
{
    public class MemberDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int NumberOfAllowedShifts { get; set; }

        public byte SoldierTypeId { get; set; }

    }
}
