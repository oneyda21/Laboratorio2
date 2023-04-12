﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio2.Models;

public partial class NotaEstudianteContext : DbContext
{
    public NotaEstudianteContext()
    {
    }

    public NotaEstudianteContext(DbContextOptions<NotaEstudianteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Notas> Nota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-AFQVQOB\\SQLEXPRESS01;Database=NotaEstudiante;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Notas>(entity =>
        {
            entity.HasKey(e => e.IdNotas);

            entity.Property(e => e.Lab1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Lab2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Lab3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NombreEstudiante)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Parcial1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Parcial2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Parcial3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Resultado).HasColumnType("decimal(38, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
