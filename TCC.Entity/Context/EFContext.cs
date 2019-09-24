using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TCC.Domain.Entities;

namespace TCC.Entity.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("TCCConnectionDB") { }

        #region Gets do Entity

        public virtual DbSet<ETUserPublic> UsersPublic { get; set; }
        public virtual DbSet<ETUserAdmin> UsersAdmin { get; set; }
        public virtual DbSet<ETMenu> Menus { get; set; }
        public virtual DbSet<ETMenuItem> MenusItens { get; set; }
        public virtual DbSet<ETMenuType> MenusTypes { get; set; }
        public virtual DbSet<ETContent> Contents { get; set; }
        public virtual DbSet<ETProject> Projects { get; set; }
        public virtual DbSet<ETTechnicalTutorial> TechnicalTutorials { get; set; }
        public virtual DbSet<ETUserPublicMenuItem> UserPublicMenuItens { get; set; }
        public virtual DbSet<ETHistoric> Historics { get; set; }
        public virtual DbSet<ETCardActor> CardActors { get; set; }
        public virtual DbSet<ETCardLineActor> CardLineActors { get; set; }
        public virtual DbSet<ETCardUserStory> CardUserStories { get; set; }
        public virtual DbSet<ETCardLineUserStory> CardLineUserStories { get; set; }
        public virtual DbSet<ETCardBDD> CardBDDs { get; set; }
        public virtual DbSet<ETCardLineBDD> CardLineBDDs { get; set; }

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

            MapAdmin(ref modelBuilder);
            MapPublic(ref modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        #region Mapeamento

        public void MapPublic(ref DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.MPUserPublic());
            modelBuilder.Configurations.Add(new Maps.MPProject());
            modelBuilder.Configurations.Add(new Maps.MPUserPublicMenuItem());
            modelBuilder.Configurations.Add(new Maps.MPHistoric());
            modelBuilder.Configurations.Add(new Maps.MPCardActor());
            modelBuilder.Configurations.Add(new Maps.MPCardLineActor());
            modelBuilder.Configurations.Add(new Maps.MPCardUserStory());
            modelBuilder.Configurations.Add(new Maps.MPCardLineUserStory());
            modelBuilder.Configurations.Add(new Maps.MPCardBDD());
            modelBuilder.Configurations.Add(new Maps.MPCardLineBDD());
        }

        public void MapAdmin(ref DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.MPUserAdmin());
            modelBuilder.Configurations.Add(new Maps.MPMenu());
            modelBuilder.Configurations.Add(new Maps.MPMenuItem());
            modelBuilder.Configurations.Add(new Maps.MPMenuParent());
            modelBuilder.Configurations.Add(new Maps.MPMenuType());
            modelBuilder.Configurations.Add(new Maps.MPContent());
            modelBuilder.Configurations.Add(new Maps.MPTechnicalTutorial());
        }

        #endregion
    }
}