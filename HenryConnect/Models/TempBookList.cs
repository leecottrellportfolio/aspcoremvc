using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HenryConnect.Models
{//fake repository
    public class TempBookList : IBookRepository
    {
        public IEnumerable<ABook> Book => new List<ABook>
        {
            new ABook{ BookCode = "0001", Paperback="Y", PublisherCode="PE",
            Title="Book 1", Type="FIC"},
            new ABook{ BookCode = "0002", Paperback="Y", PublisherCode="PE",
            Title="Book 2", Type="FIC"},
            new ABook{ BookCode = "0003", Paperback="Y", PublisherCode="PE",
            Title="Book 3", Type="FIC"},
            new ABook{ BookCode = "0004", Paperback="Y", PublisherCode="PE",
            Title="Book 4", Type="FIC"},
            new ABook{ BookCode = "0005", Paperback="Y", PublisherCode="PE",
            Title="Book 5", Type="FIC"}
        };
    }
}
