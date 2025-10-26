using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SCMM_Projeto.Models;

public partial class ScmmDbContext : DbContext
{
    public ScmmDbContext()
    {
    }

    public ScmmDbContext(DbContextOptions<ScmmDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Materiai> Materiais { get; set; }

    public virtual DbSet<OrdemServico> OrdemServicos { get; set; }

    public virtual DbSet<Solicitaco> Solicitacoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SCMM_DB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Materiai>(entity =>
        {
            entity.HasKey(e => e.IdMaterial).HasName("PK__Materiai__94356E58DE28DF38");

            entity.Property(e => e.NomeMaterial).HasMaxLength(100);
            entity.Property(e => e.Unidade).HasMaxLength(20);
        });

        modelBuilder.Entity<OrdemServico>(entity =>
        {
            entity.HasKey(e => e.IdOs).HasName("PK__OrdemSer__B770330F0683225E");

            entity.ToTable("OrdemServico");

            entity.Property(e => e.IdOs).HasColumnName("IdOS");
            entity.Property(e => e.DataAbertura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NumeroOs)
                .HasMaxLength(20)
                .HasColumnName("NumeroOS");
            entity.Property(e => e.Responsavel).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Solicitaco>(entity =>
        {
            entity.HasKey(e => e.IdSolicitacao).HasName("PK__Solicita__A3FBDD9849C348BC");

            entity.Property(e => e.DataSolicitacao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Solicitante).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.Solicitacos)
                .HasForeignKey(d => d.IdMaterial)
                .HasConstraintName("FK__Solicitac__IdMat__3A81B327");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
