﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

public partial class KoodaajakoulutusContext : DbContext
{
    public KoodaajakoulutusContext()
    {
    }

    public KoodaajakoulutusContext(DbContextOptions<KoodaajakoulutusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:koodajakoulutusexample23ka.database.windows.net,1433;Initial Catalog=koodaajakoulutus;Persist Security Info=False;User ID=Ola;Password=Aulaaws1989a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Persons__AA2FFBE5F1F1BFC2");

            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
