namespace MeowBand_project
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<t_comment> t_comment { get; set; }
        public virtual DbSet<t_composition> t_composition { get; set; }
        public virtual DbSet<t_compositiongenre> t_compositiongenre { get; set; }
        public virtual DbSet<t_genre> t_genre { get; set; }
        public virtual DbSet<t_user> t_user { get; set; }
        public virtual DbSet<t_userlikes> t_userlikes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_comment>()
                .Property(e => e.comment_text)
                .IsUnicode(false);

            modelBuilder.Entity<t_composition>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_composition>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_composition>()
                .Property(e => e.artists)
                .IsUnicode(false);

            modelBuilder.Entity<t_composition>()
                .Property(e => e.composers)
                .IsUnicode(false);

            modelBuilder.Entity<t_composition>()
                .Property(e => e.album)
                .IsUnicode(false);

            modelBuilder.Entity<t_composition>()
                .HasMany(e => e.t_comment)
                .WithRequired(e => e.t_composition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<t_composition>()
                .HasMany(e => e.t_compositiongenre)
                .WithRequired(e => e.t_composition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<t_composition>()
                .HasMany(e => e.t_userlikes)
                .WithRequired(e => e.t_composition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<t_genre>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_genre>()
                .HasMany(e => e.t_compositiongenre)
                .WithRequired(e => e.t_genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.userlogin)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.userpass)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .HasMany(e => e.t_comment)
                .WithRequired(e => e.t_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<t_user>()
                .HasMany(e => e.t_composition)
                .WithRequired(e => e.t_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<t_user>()
                .HasMany(e => e.t_userlikes)
                .WithRequired(e => e.t_user)
                .WillCascadeOnDelete(false);
        }
    }
}
