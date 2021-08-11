using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBH_APIs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestTableController : ControllerBase
    {
        private readonly GuestTableRepository guestTableRepository;

        public GuestTableController(GuestTableRepository guestTableRepository)
        {
            this.guestTableRepository = guestTableRepository;
        }
    }
}
