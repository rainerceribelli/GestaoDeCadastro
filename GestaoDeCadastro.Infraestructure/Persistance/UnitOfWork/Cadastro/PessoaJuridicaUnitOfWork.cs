using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using GestaoDeCadastro.Infraestructure.Persistance.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro
{
    public class PessoaJuridicaUnitOfWork : GenericUnitOfWork
    {
        public PessoaJuridicaRepository PessoaJuridicaRepository => _serviceProvider.GetService<PessoaJuridicaRepository>();

        public PessoaJuridicaUnitOfWork(GestaoDeCadastroModel context, IServiceProvider serviceProvider)
            : base(context, serviceProvider)
        {

        }
    }
}
