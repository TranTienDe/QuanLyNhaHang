using QLBH_APIs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class OrderItemRepository
    {
        private readonly AppDbContext dbContext;

        public OrderItemRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
