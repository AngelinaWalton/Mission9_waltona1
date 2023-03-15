using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_waltona1.Models
{
    public interface IPurchaseRepository
    {
        //if you leavve public off the default is to make it public
        IQueryable<Purchase> Purchases { get; }

        void savePurchase(Purchase purchase);
    }
}
