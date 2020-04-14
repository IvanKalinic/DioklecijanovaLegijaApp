namespace DioklecijanovaLegija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int NumberOfAllowedShifts { get; set; }
    }
}
