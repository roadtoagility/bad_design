using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EntrevistaApp.Domain.Entities;

namespace EntrevistaApp.Infrastructure.Repository.Context
{
    public partial class BD_EntrevistaAppContext : DbContext
    {
        public BD_EntrevistaAppContext()
        {
        }

        public BD_EntrevistaAppContext(DbContextOptions<BD_EntrevistaAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Questao> Questao { get; set; }
        public virtual DbSet<QuestaoQuestionario> QuestaoQuestionario { get; set; }
        public virtual DbSet<Questionario> Questionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=SQNOT12644;Initial Catalog=BD_EntrevistaApp;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questao>(entity =>
            {
                entity.ToTable("TB_QUESTAO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enunciado)
                    .IsRequired()
                    .HasColumnName("ENUNCIADO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");
            });

            modelBuilder.Entity<QuestaoQuestionario>(entity =>
            {
                entity.ToTable("TB_QUESTAO_QUESTIONARIO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdQuestao).HasColumnName("ID_QUESTAO");

                entity.Property(e => e.IdQuestionario).HasColumnName("ID_QUESTIONARIO");

                entity.HasOne(d => d.IdQuestaoNavigation)
                    .WithMany(p => p.QuestaoQuestionario)
                    .HasForeignKey(d => d.IdQuestao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_QUESTAO_QUESTIONARIO_TB_QUESTAO");

                entity.HasOne(d => d.IdQuestionarioNavigation)
                    .WithMany(p => p.QuestaoQuestionario)
                    .HasForeignKey(d => d.IdQuestionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_QUESTAO_QUESTIONARIO_TB_QUESTIONARIO");
            });

            modelBuilder.Entity<Questionario>(entity =>
            {
                entity.ToTable("TB_QUESTIONARIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
