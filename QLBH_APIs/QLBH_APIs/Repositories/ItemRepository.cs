using QLBH_APIs.Data;
using QLBH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class ItemRepository
    {
        private readonly AppDbContext dbContext;

        public ItemRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Item> GetItems()
        {
            return this.dbContext.Items.ToList();
        }

    }
}
