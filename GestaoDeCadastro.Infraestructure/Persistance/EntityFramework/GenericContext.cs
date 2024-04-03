using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
