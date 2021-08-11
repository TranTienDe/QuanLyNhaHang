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
    public class UnitTypeController : ControllerBase
    {
        private readonly UnitTypeRepository unitTypeRepository;

        public UnitTypeController(UnitTypeRepository unitTypeRepository)
        {
            this.unitTypeRepository = unitTypeRepository;
        }
    }
}
