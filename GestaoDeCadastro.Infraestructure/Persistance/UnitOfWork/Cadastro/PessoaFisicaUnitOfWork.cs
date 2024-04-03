using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using GestaoDeCadastro.Infraestructure.Persistance.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro
{
    public class PessoaFisicaUnitOfWork : GenericUnitOfWork
    {
        public PessoaFisicaRepository PessoaFisicaRepository => _serviceProvider.GetService<PessoaFisicaRepository>();

        public PessoaFisicaUnitOfWork(GestaoDeCadastroModel context, IServiceProvider serviceProvider)
            : base(context, serviceProvider)
        {

        }
    }
}
