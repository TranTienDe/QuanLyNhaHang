using QLBH_APIs.Data;
using QLBH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class CategoryRepository
    {
        private readonly AppDbContext dbContext;

        public CategoryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Category> GetCategories()
        {
            try
            {
                return this.dbContext.Categories.ToList();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
