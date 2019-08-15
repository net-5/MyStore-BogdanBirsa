using MyStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Repositories
{
    public interface IShipperRepository
    {
        List<Shippers> GetAllShippers();
    }
    public class ShipperRepository : IShipperRepository
    {
        private readonly StoreContext storeContext;
        public ShipperRepository(StoreContext store)
        {
            storeContext = store;
        }

        public List<Shippers> GetAllShippers()
        {
            return storeContext.Shippers.ToList();
        }

    }
}
