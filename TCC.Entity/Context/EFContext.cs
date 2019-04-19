using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TCC.Domain.Entities;

namespace TCC.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("TCC.DB") { }

        //public DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.Id))
                .Configure(p =>
                {
                    p.IsKey();
                    p.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                });

            modelBuilder.Properties<string>()
                .Configure(e => e.HasColumnType("VARCHAR"));

            modelBuilder.Properties<string>()
                .Configure(e => e.HasMaxLength(100));

            modelBuilder.Properties<decimal>()
                .Configure(e => e.HasPrecision(4, 2));

            //modelBuilder.Configurations.Add(new Maps.ModuleMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}