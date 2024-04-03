using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
