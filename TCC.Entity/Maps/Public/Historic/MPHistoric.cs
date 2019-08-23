using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPHistoric<T> : EntityTypeConfiguration<T>
        where T : ETHistoric
    {
        public MPHistoric()
        {
            Property(e => e.IdUserPublic)
                .IsRequired()
                .HasColumnName("ID_USER_PUBLIC_N");

            Property(e => e.IdProject)
                .IsRequired()
                .HasColumnName("ID_PROJECT_N");
        }
    }
}
