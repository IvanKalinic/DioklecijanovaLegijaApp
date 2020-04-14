using DioklecijanovaLegija.Models;
using System.Data.Entity.ModelConfiguration;

namespace DioklecijanovaLegija.EntityTypeConfigurations
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(m => m.SoldierTypeId)
                .IsRequired();


        }
    }
}
