using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HenryConnect.Models
{
    public class EFBookRepository : IBookRepository
    {
        private HenryDbContext context;
        public IEnumerable<ABook> Book => context.Book;

        public EFBookRepository(HenryDbContext ctx)
        {
            context = ctx;
        }
    }
}
