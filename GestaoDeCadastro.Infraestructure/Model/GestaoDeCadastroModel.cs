using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeCadastro.Infraestructure.Model
{
    public class GestaoDeCadastroModel : GenericContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public GestaoDeCadastroModel(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<tPessoa> tPessoa { get; set; }
        public DbSet<tPessoaFisica> tPessoaFisica { get; set; }
        public DbSet<tPessoaJuridica> tPessoaJuridica { get; set; }
    }
}
