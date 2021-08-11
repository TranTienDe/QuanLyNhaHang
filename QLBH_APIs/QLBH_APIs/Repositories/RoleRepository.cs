using QLBH_APIs.Data;
using QLBH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Repositories
{
    public class RoleRepository
    {
        private readonly AppDbContext dbContext;

        public RoleRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Role> GetRoles()
        {
            return this.dbContext.Roles.ToList();
        }

        public Role GetRoleById(int Id)
        {
            return this.dbContext.Roles.Where(role => role.Id == Id).FirstOrDefault();
        }

        public Role Insert(Role role)
        {
            this.dbContext.Roles.Add(role);
            this.dbContext.SaveChanges();
            return role;
        }
    }
}
