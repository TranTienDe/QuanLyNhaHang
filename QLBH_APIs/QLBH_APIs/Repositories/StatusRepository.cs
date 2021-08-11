using QLBH_APIs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class StatusRepository
    {
        private readonly AppDbContext dbContext;

        public StatusRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
