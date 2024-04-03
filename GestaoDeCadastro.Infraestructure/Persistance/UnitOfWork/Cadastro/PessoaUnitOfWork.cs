using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using GestaoDeCadastro.Infraestructure.Persistance.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro
{
    public class PessoaUnitOfWork : GenericUnitOfWork
    {
        public PessoaRepository PessoaRepository => _serviceProvider.GetService<PessoaRepository>();
        public PessoaFisicaRepository PessoaFisicaRepository => _serviceProvider.GetService<PessoaFisicaRepository>();
        public PessoaJuridicaRepository PessoaJuridicaRepository => _serviceProvider.GetService<PessoaJuridicaRepository>();

        public PessoaUnitOfWork(GestaoDeCadastroModel context, IServiceProvider serviceProvider)
            : base(context, serviceProvider)
        {

        }
    }
}
