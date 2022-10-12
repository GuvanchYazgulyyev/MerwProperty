using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataObject.MerwPropDB
{
    public partial class AizizPulishingDbContext : DbContext
    {
        public AizizPulishingDbContext()
        {
        }

        public AizizPulishingDbContext(DbContextOptions<AizizPulishingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllCity> AllCities { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<EnAllCity> EnAllCities { get; set; } = null!;
        public virtual DbSet<EnCategory> EnCategories { get; set; } = null!;
        public virtual DbSet<EnComment> EnComments { get; set; } = null!;
        public virtual DbSet<EnContact> EnContacts { get; set; } = null!;
        public virtual DbSet<EnDelegate> EnDelegates { get; set; } = null!;
        public virtual DbSet<EnImage> EnImages { get; set; } = null!;
        public virtual DbSet<EnReferance> EnReferances { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<PublishingAdvert> PublishingAdverts { get; set; } = null!;
        public virtual DbSet<RuAboutU> RuAboutUs { get; set; } = null!;
        public virtual DbSet<RuAllCity> RuAllCities { get; set; } = null!;
        public virtual DbSet<RuCategory> RuCategories { get; set; } = null!;
        public virtual DbSet<RuComment> RuComments { get; set; } = null!;
        public virtual DbSet<RuContact> RuContacts { get; set; } = null!;
        public virtual DbSet<RuDelegate> RuDelegates { get; set; } = null!;
        public virtual DbSet<RuImage> RuImages { get; set; } = null!;
        public virtual DbSet<RuPublishingAdvert> RuPublishingAdverts { get; set; } = null!;
        public virtual DbSet<RuReferance> RuReferances { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=DESKTOP-VHM3JVU; initial catalog=AizizPulishingDb;User ID=sa; Password=Guga97;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllCity>(entity =>
            {
                entity.ToTable("AllCity");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AllCities)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_AllCity_Categories");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Categories_AllCity");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CityName).HasMaxLength(200);

                entity.Property(e => e.CommentNameSurname).HasMaxLength(300);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.PublishingAdvert)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PublishingAdvertId)
                    .HasConstraintName("FK_Comments_PublishingAdvert");
            });

            modelBuilder.Entity<EnAllCity>(entity =>
            {
                entity.ToTable("En_AllCity");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.EnAllCities)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_En_AllCity_En_Categories");
            });

            modelBuilder.Entity<EnCategory>(entity =>
            {
                entity.ToTable("En_Categories");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.EnCategories)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_En_Categories_En_AllCity");
            });

            modelBuilder.Entity<EnComment>(entity =>
            {
                entity.ToTable("En_Comments");

                entity.Property(e => e.CityName).HasMaxLength(200);

                entity.Property(e => e.CommentNameSurname).HasMaxLength(300);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnContact>(entity =>
            {
                entity.ToTable("En_Contact");

                entity.Property(e => e.AddressDescription).HasMaxLength(600);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Mail).HasMaxLength(200);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.WorkingTimes).HasMaxLength(500);
            });

            modelBuilder.Entity<EnDelegate>(entity =>
            {
                entity.ToTable("En_Delegates");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.NameSurname).HasMaxLength(500);

                entity.Property(e => e.TaskName).HasMaxLength(500);

                entity.Property(e => e.TelNo).HasMaxLength(50);
            });

            modelBuilder.Entity<EnImage>(entity =>
            {
                entity.ToTable("En_Images");

                entity.Property(e => e.ImageName).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<EnReferance>(entity =>
            {
                entity.ToTable("En_Referance");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.ImageName).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.PublishingAdvert)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.PublishingAdvertId)
                    .HasConstraintName("FK_Images_PublishingAdvert");
            });

            modelBuilder.Entity<PublishingAdvert>(entity =>
            {
                entity.ToTable("PublishingAdvert");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AdvertNo).HasMaxLength(50);

                entity.Property(e => e.BathRoom).HasMaxLength(90);

                entity.Property(e => e.BedCount).HasMaxLength(50);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Garage).HasMaxLength(90);

                entity.Property(e => e.Price).HasMaxLength(50);

                entity.Property(e => e.PublishName).HasMaxLength(100);

                entity.Property(e => e.PublishStatus).HasMaxLength(50);

                entity.Property(e => e.RoomCount).HasMaxLength(50);

                entity.Property(e => e.YearsOfStatus).HasMaxLength(50);

                entity.HasOne(d => d.Categori)
                    .WithMany(p => p.PublishingAdverts)
                    .HasForeignKey(d => d.CategoriId)
                    .HasConstraintName("FK_PublishingAdvert_Categories");
            });

            modelBuilder.Entity<RuAboutU>(entity =>
            {
                entity.ToTable("Ru_AboutUs");

                entity.Property(e => e.AboutUs).HasMaxLength(500);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RuAllCity>(entity =>
            {
                entity.ToTable("Ru_AllCity");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RuAllCities)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Ru_AllCity_Ru_Categories");
            });

            modelBuilder.Entity<RuCategory>(entity =>
            {
                entity.ToTable("Ru_Categories");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.RuCategories)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Ru_Categories_Ru_AllCity");
            });

            modelBuilder.Entity<RuComment>(entity =>
            {
                entity.ToTable("Ru_Comments");

                entity.Property(e => e.CityName).HasMaxLength(200);

                entity.Property(e => e.CommentNameSurname).HasMaxLength(300);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.PublishingAdvert)
                    .WithMany(p => p.RuComments)
                    .HasForeignKey(d => d.PublishingAdvertId)
                    .HasConstraintName("FK_Ru_Comments_Ru_PublishingAdvert");
            });

            modelBuilder.Entity<RuContact>(entity =>
            {
                entity.ToTable("Ru_Contact");

                entity.Property(e => e.AddressDescription).HasMaxLength(600);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Mail).HasMaxLength(200);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.WorkingTimes).HasMaxLength(500);
            });

            modelBuilder.Entity<RuDelegate>(entity =>
            {
                entity.ToTable("Ru_Delegates");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.NameSurname).HasMaxLength(500);

                entity.Property(e => e.TaskName).HasMaxLength(500);

                entity.Property(e => e.TelNo).HasMaxLength(50);
            });

            modelBuilder.Entity<RuImage>(entity =>
            {
                entity.ToTable("Ru_Images");

                entity.Property(e => e.ImageName).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.PublishingAdvert)
                    .WithMany(p => p.RuImages)
                    .HasForeignKey(d => d.PublishingAdvertId)
                    .HasConstraintName("FK_Ru_Images_Ru_PublishingAdvert");
            });

            modelBuilder.Entity<RuPublishingAdvert>(entity =>
            {
                entity.ToTable("Ru_PublishingAdvert");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AdvertNo).HasMaxLength(50);

                entity.Property(e => e.BathRoom).HasMaxLength(90);

                entity.Property(e => e.BedCount).HasMaxLength(50);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Garage).HasMaxLength(90);

                entity.Property(e => e.Price).HasMaxLength(50);

                entity.Property(e => e.PublishName).HasMaxLength(100);

                entity.Property(e => e.PublishStatus).HasMaxLength(50);

                entity.Property(e => e.RoomCount).HasMaxLength(50);

                entity.Property(e => e.YearsOfStatus).HasMaxLength(50);

                entity.HasOne(d => d.Categori)
                    .WithMany(p => p.RuPublishingAdverts)
                    .HasForeignKey(d => d.CategoriId)
                    .HasConstraintName("FK_Ru_PublishingAdvert_Ru_Categories");
            });

            modelBuilder.Entity<RuReferance>(entity =>
            {
                entity.ToTable("Ru_Referance");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
