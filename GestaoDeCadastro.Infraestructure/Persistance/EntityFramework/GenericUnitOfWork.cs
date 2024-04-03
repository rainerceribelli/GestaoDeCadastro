using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Infraestructure.Persistance.EntityFramework
{
    public class GenericUnitOfWork
    {
        protected GenericContext Context {get; set;}
        protected readonly IServiceProvider _serviceProvider;

        public GenericUnitOfWork(GenericContext context, IServiceProvider serviceProvider)
        {
            Context = context;
            _serviceProvider = serviceProvider;
        }

        public async Task CommitAsync()
        {
            Context.ChangeTracker.DetectChanges();
            await Context.SaveChangesAsync();
        }
    }
}
