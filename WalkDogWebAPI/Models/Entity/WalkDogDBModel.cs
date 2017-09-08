namespace WalkDogWebAPI.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WalkDogDBModel : DbContext
    {
        public WalkDogDBModel()
            : base("name=WalkDogDBModel")
        {
            base.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Cachorro> Cachorro { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Passeio> Passeio { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cachorro>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cachorro>()
                .Property(e => e.porte)
                .IsUnicode(false);

            modelBuilder.Entity<Cachorro>()
                .Property(e => e.agressividade)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.tipoLogradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.nomeLogradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Endereco)
                .HasForeignKey(e => e.idEndereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passeio>()
                .Property(e => e.ultimoLocal)
                .IsUnicode(false);

            modelBuilder.Entity<Passeio>()
                .HasMany(e => e.Avaliacao)
                .WithRequired(e => e.Passeio)
                .HasForeignKey(e => e.idPasseio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.facebook)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Cachorro)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.idDono)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Passeio)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.idUsuarioPasseador)
                .WillCascadeOnDelete(false);            
        }
    }
}
