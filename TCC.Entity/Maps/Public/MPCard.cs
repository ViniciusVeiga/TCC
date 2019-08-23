using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCard<T> : EntityTypeConfiguration<T> 
        where T : ETCard
    {
        public MPCard()
        {
            Property(e => e.IdHistoric)
                .IsRequired()
                .HasColumnName("ID_HISTORIC_N");
        }
    }
}
