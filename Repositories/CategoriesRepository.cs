using MyStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Repositories
{
    public interface ICategoryRepository
    {
        List<Categories> GetAllCategories();
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext storeContext;
        public CategoryRepository(StoreContext store)
        {
            storeContext = store;
        }

        List<Categories> ICategoryRepository.GetAllCategories()
        {
            return storeContext.Categories.ToList();
        }
    }
}
