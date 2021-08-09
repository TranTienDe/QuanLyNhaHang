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
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;

        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userRepository.GetUsers();
        }
    }
}
