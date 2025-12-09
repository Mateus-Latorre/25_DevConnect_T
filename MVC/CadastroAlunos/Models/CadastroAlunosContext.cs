using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunos.Models;

public partial class CadastroAlunosContext : DbContext
{
    public CadastroAlunosContext()
    {
    }

    public CadastroAlunosContext(DbContextOptions<CadastroAlunosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Fruta> Frutas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTE09-S21\\SQLEXPRESS;User Id=sa; Password=senai@134; Database=CadastroAlunos;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aluno__3214EC079B90F541");
        });

        modelBuilder.Entity<Fruta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Frutas__3214EC07C4E8CACA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
