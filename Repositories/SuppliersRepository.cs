using MyStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Repositories
{
    public interface ISupplierRepository
    {
        List<Suppliers> GetAllSuppliers();
    }
    public class SupplierRepository : ISupplierRepository
    {
        private readonly StoreContext storeContext;
        public SupplierRepository(StoreContext store)
        {
            storeContext = store;
        }

        public List<Suppliers> GetAllSuppliers()
        {
            return storeContext.Suppliers.ToList();
        }
    }
}
