using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;

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
