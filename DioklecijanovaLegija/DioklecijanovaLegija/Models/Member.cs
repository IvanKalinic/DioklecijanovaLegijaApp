using System;

namespace DioklecijanovaLegija.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int NumberOfAllowedShifts { get; set; }

        public byte SoldierTypeId { get; set; }

        public SoldierType SoldierType { get; set; }
    }
}
