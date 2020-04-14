namespace DioklecijanovaLegija
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DioklecijanovaLegija : DbContext
    {
        public DioklecijanovaLegija()
            : base("name=DioklecijanovaLegija")
        {
        }

        public virtual DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
