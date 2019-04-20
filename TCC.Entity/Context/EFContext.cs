using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TCC.Domain.Entities;
using TCC.Domain.Entities.Security;

namespace TCC.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("TCCConnectionDB") { }

        public DbSet<ETUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            #region Configuração Base

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.Id))
                .Configure(p =>
                {
                    p.IsKey();
                    p.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                    p.HasColumnName("BAS_N_ID");
                });

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.AddedDate))
                .Configure(p =>
                {
                    p.HasColumnName("BAS_D_ADDED_DATE");
                });

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.ModifiedDate))
                .Configure(p =>
                {
                    p.HasColumnName("BAS_D_MODIFIED_DATE");
                });

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.Active))
                .Configure(p =>
                {
                    p.HasColumnName("BAS_B_ACTIVE");
                });

            #endregion

            modelBuilder.Properties<string>()
                .Configure(e => e.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(e => e.HasMaxLength(100));

            modelBuilder.Properties<decimal>()
                .Configure(e => e.HasPrecision(4, 2));

            modelBuilder.Configurations.Add(new Maps.MPUser());

            base.OnModelCreating(modelBuilder);
        }
    }
}