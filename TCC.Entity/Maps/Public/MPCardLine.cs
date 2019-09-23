using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardLine<T> : EntityTypeConfiguration<T> 
        where T : ETCardLine
    {
        public MPCardLine()
        {
            Property(e => e.Line)
                .IsRequired()
                .HasColumnName("LINE_C");
        }
    }
}
