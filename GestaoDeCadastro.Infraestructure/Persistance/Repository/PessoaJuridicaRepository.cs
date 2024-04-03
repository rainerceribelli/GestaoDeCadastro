using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;

namespace GestaoDeCadastro.Infraestructure.Persistance.Repository
{
    public class PessoaJuridicaRepository : GenericRepository<tPessoaJuridica, GestaoDeCadastroModel>
    {
        public PessoaJuridicaRepository(GestaoDeCadastroModel context)
            : base(context)
        {
        }
    }
}
