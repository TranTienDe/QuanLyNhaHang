using QLBH_APIs.Data;
using QLBH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<User> GetUsers()
        {
            return this.dbContext.Users.ToList();
        }
    }
}
