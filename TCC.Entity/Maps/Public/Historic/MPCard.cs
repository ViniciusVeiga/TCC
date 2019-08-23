using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class Historic<T> : EntityTypeConfiguration<T> 
        where T : ETCard
    {
        public Historic()
        {
            try
            {
                Property(e => e.IdUserPublic)
                    .IsRequired()
                    .HasColumnName("ID_USER_PUBLIC");
            }
            catch { }

        }
    }
}
