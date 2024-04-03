using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;

namespace GestaoDeCadastro.Infraestructure.Persistance.Repository
{
    public class PessoaFisicaRepository : GenericRepository<tPessoaFisica, GestaoDeCadastroModel>
    {
        public PessoaFisicaRepository(GestaoDeCadastroModel context)
            : base(context)
        {
        }
    }
}
