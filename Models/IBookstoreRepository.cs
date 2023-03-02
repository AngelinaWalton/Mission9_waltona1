using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_waltona1.Models
{
    //an interface is a template for a class
    public interface IBookStoreRepository
    {
        IQueryable<Books> Books { get; }
    }
}
