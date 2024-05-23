using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Chi.Exhibition.Repository.Models;

public partial class _ChiExhDbContext : DbContext
{
    public _ChiExhDbContext()
    {
    }

    public _ChiExhDbContext(DbContextOptions<_ChiExhDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserEntity> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(48)
                .IsUnicode(false);
            entity.Property(e => e.RefreshToken).HasMaxLength(1024);
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(88);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
