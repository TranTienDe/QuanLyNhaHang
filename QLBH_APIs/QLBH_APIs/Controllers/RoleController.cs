using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBH_APIs.Models;
using QLBH_APIs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleRepository roleRepository;

        public RoleController(RoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        /// <summary>
        /// Lấy tất cả danh sách Roles.
        /// </summary>
        /// <returns>Danh sách Roles</returns>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return this.roleRepository.GetRoles();
        }

        /// <summary>
        /// Lấy Role theo tham số Id
        /// </summary>
        /// <param name="Id">Đầu vào là 1 Id của Role</param>
        /// <returns>Trả về 1 Role</returns>
        [HttpGet("Id")]
        public Role Get([FromQuery] int Id)
        {
            return this.roleRepository.GetRoleById(Id);
        }

        /// <summary>
        /// Thêm mới Role
        /// </summary>
        /// <param name="role"></param>
        /// <returns>Role</returns>
        [HttpPost]
        public Role Post([FromQuery] Role role)
        {
            return this.roleRepository.Insert(role);
        }
    }
}
