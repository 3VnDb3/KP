using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookStore.Infrastructure
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<ClientEntity> client { get; set; }
        public virtual DbSet<DolznostbEntity> dolznostb { get; set; }
        public virtual DbSet<RazvlekCenterEntity> razvlekCenter { get; set; }
        public virtual DbSet<RoleEntity> role { get; set; }
        public virtual DbSet<SotrudnikEntity> sotrudnik { get; set; }
        public virtual DbSet<UserEntity> user { get; set; }
        public virtual DbSet<UslugiEntity> uslugi { get; set; }
        public virtual DbSet<ZakazEntity> zakaz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>()
                .HasMany(e => e.zakaz)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.idclienta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DolznostbEntity>()
                .HasMany(e => e.sotrudnik)
                .WithRequired(e => e.dolznostb)
                .HasForeignKey(e => e.iddolzotb)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleEntity>()
                .HasMany(e => e.user)
                .WithRequired(e => e.role)
                .HasForeignKey(e => e.idrole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UslugiEntity>()
                .HasMany(e => e.zakaz)
                .WithRequired(e => e.uslugi)
                .HasForeignKey(e => e.iduslugi)
                .WillCascadeOnDelete(false);
        }
    }
}
