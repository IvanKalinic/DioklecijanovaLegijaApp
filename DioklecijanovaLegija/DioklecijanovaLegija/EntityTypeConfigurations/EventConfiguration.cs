using DioklecijanovaLegija.Models;
using System.Data.Entity.ModelConfiguration;

namespace DioklecijanovaLegija.EntityTypeConfigurations
{
    public class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            //Property(e => e.NumberOfMembers)
            //    .HasColumnName("NumberOfMembers");
        }
    }
}
