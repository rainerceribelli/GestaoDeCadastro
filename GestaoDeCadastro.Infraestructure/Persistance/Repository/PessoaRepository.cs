using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Infraestructure.Persistance.Repository
{
    public class PessoaRepository : GenericRepository<tPessoa, GestaoDeCadastroModel>
    {
        public PessoaRepository(GestaoDeCadastroModel context) 
            : base(context)
        {
        }
    }
}
