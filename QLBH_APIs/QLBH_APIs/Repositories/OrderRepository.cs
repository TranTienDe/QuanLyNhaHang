using QLBH_APIs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class OrderRepository
    {
        private readonly AppDbContext dbContext;

        public OrderRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
