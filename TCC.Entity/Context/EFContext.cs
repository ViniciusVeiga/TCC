using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TCC.Domain.Entities;
using TCC.Domain.Entities.Security;

namespace TCC.Entity.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("TCCConnectionDB") { }

        #region Gets do Entity

        public virtual DbSet<ETUser> Users { get; set; }
        public virtual DbSet<ETMenuItem> MenusItens { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #region Configuração Base

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.Id))
                .Configure(p =>
                {
                    p.IsKey();
                    p.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                    p.HasColumnName("ID_N");
                });

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.AddedDate))
                .Configure(p =>
                {
                    p.HasColumnName("ADDED_DATE_D");
                });

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.ModifiedDate))
                .Configure(p =>
                {
                    p.HasColumnName("MODIFIED_DATE_D");
                });

            modelBuilder.Properties()
                .Where(p => p.Name == nameof(ETBase.Active))
                .Configure(p =>
                {
                    p.HasColumnName("ACTIVE_B");
                });

            #endregion

            modelBuilder.Properties<string>()
                .Configure(e => e.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(e => e.HasMaxLength(150));

            modelBuilder.Properties<decimal>()
                .Configure(e => e.HasPrecision(18, 0));

            #region Mapeamento

            modelBuilder.Configurations.Add(new Maps.MPUser());
            modelBuilder.Configurations.Add(new Maps.MPMenuItem());

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}