using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data;

using iniciativa.Models;

namespace iniciativa.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<IniciativaWoman> Iniciativas {get;set;}
        public DbSet<Evento> Eventos {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
             optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=root;Database=iniciativa");

         }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IniciativaWoman>(p =>
            {
                p.ToTable("IniciativaWoman");
                p.HasKey(p =>p.id );
                p.Property(p => p.Nome ).HasColumnType("varchar(80)").IsRequired();
                p.Property(p => p.Descricao ).HasColumnType("varchar(512)").IsRequired();
                p.Property(p => p.Imagem ).HasColumnType("varchar(150)").IsRequired();
                p.Property(p => p.url ).HasColumnType("varchar(150)").IsRequired();
                


            });

            builder.Entity<Evento>(p =>
            {
                p.ToTable("Evento");
                p.HasKey(p=> p.Id);
                p.Property(p=> p.Nome).HasColumnType("varchar(80)");
                p.Property(p=> p.Descricao).HasColumnType("varchar(250)");
                p.Property(p=> p.Data).HasColumnType("Date" );
                p.Property(p=> p.Endereco).HasColumnType("varchar(250)");
                p.HasOne(p => p.iniciativaWoman).WithMany(p => p.Eventos).OnDelete(DeleteBehavior.Cascade);

            }
            
            );
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
        
    }
}