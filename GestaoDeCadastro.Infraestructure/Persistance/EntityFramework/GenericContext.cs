using Microsoft.EntityFrameworkCore;

namespace GestaoDeCadastro.Infraestructure.Persistance.EntityFramework
{
    public class GenericContext : DbContext
    {
        public GenericContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
