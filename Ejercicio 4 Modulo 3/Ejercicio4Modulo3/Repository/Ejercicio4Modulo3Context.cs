﻿#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio4Modulo3.Models;

public partial class Ejercicio4Modulo3Context : DbContext
{
    public Ejercicio4Modulo3Context(DbContextOptions<Ejercicio4Modulo3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Logs> Logs { get; set; }

    public virtual DbSet<Proveedor> Proveedor { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Logs>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__logs__3213E83F714146A5")
            entity.ToTable("logs");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Method)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("method");
            entity.Property(e => e.Path)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("path");
            entity.Property(e => e.Success).HasColumnName("success");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__proveedo__3213E83F4D134D68");
            entity.ToTable("proveedor");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodProveedor)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cod_proveedor");
            entity.Property(e => e.RazonSocial)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razon_social");
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}