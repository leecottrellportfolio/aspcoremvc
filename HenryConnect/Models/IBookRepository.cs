using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HenryConnect.Models
{
    public interface IBookRepository
    {
        IEnumerable<ABook> Book { get; }
        //the name MUST match the table name
    }
}
