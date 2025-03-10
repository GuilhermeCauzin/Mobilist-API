using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MobilistAPI.Models;

public partial class ProjetoMobilistContext : MobilistIdentityContext
{
    public ProjetoMobilistContext(DbContextOptions<ProjetoMobilistContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Checklist> Checklists { get; set; }

    public virtual DbSet<DetalhesCarro> DetalhesCarros { get; set; }

    public virtual DbSet<FotosVeiculo> FotosVeiculos { get; set; }

    public virtual DbSet<Iten> Itens { get; set; }

    public virtual DbSet<ItensChecklist> ItensChecklists { get; set; }

    public virtual DbSet<Lado> Lados { get; set; }

    public virtual DbSet<Peca> Pecas { get; set; }

    public virtual DbSet<PecasChecklist> PecasChecklists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 

        modelBuilder.Entity<Checklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Checklis__3214EC271218D380");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ano)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cor)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataHora).HasColumnType("datetime");
            entity.Property(e => e.MarcaModelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NomeMotorista)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observações).IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quilometragem)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TelefoneMotorista)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetalhesCarro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Detalhes__3214EC2790333606");

            entity.ToTable("DetalhesCarro");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FileName).IsUnicode(false);

            entity.HasOne(d => d.IdChecklistNavigation).WithMany(p => p.DetalhesCarros)
                .HasForeignKey(d => d.IdChecklist)
                .HasConstraintName("FK__DetalhesC__IdChe__4AB81AF0");
        });

        modelBuilder.Entity<FotosVeiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FotosVei__3214EC270091D146");

            entity.ToTable("FotosVeiculo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FileName).IsUnicode(false);

            entity.HasOne(d => d.IdChecklistNavigation).WithMany(p => p.FotosVeiculos)
                .HasForeignKey(d => d.IdChecklist)
                .HasConstraintName("FK__FotosVeic__IdChe__47DBAE45");

            entity.HasOne(d => d.IdLadoNavigation).WithMany(p => p.FotosVeiculos)
                .HasForeignKey(d => d.IdLado)
                .HasConstraintName("FK__FotosVeic__IdLad__46E78A0C");
        });

        modelBuilder.Entity<Iten>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Itens__3214EC27769E0B50");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItensChecklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ItensChe__3214EC2706696EA7");

            entity.ToTable("ItensChecklist");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.IdChecklistNavigation).WithMany(p => p.ItensChecklists)
                .HasForeignKey(d => d.IdChecklist)
                .HasConstraintName("FK__ItensChec__IdChe__3E52440B");

            entity.HasOne(d => d.IdItemNavigation).WithMany(p => p.ItensChecklists)
                .HasForeignKey(d => d.IdItem)
                .HasConstraintName("FK__ItensChec__IdIte__3D5E1FD2");
        });

        modelBuilder.Entity<Lado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lados__3214EC27C660BFC7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Peca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pecas__3214EC2708C2AE61");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PecasChecklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PecasChe__3214EC27C62DD249");

            entity.ToTable("PecasChecklist");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.IdChecklistNavigation).WithMany(p => p.PecasChecklists)
                .HasForeignKey(d => d.IdChecklist)
                .HasConstraintName("FK__PecasChec__IdChe__4222D4EF");

            entity.HasOne(d => d.IdPecaNavigation).WithMany(p => p.PecasChecklists)
                .HasForeignKey(d => d.IdPeca)
                .HasConstraintName("FK__PecasChec__IdPec__412EB0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
