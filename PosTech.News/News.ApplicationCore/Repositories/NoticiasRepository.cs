using News.ApplicationCore.Data;
using News.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationCore.Repositories
{
    public class NoticiasRepository : GenericRepository<Noticia>, INoticiasRepository
    {
        public NoticiasRepository(AppDbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}
