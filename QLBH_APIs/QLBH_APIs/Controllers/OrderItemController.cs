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
    public class OrderItemController : ControllerBase
    {
        private readonly OrderItemRepository orderItemRepository;

        public OrderItemController(OrderItemRepository orderItemRepository)
        {
            this.orderItemRepository = orderItemRepository;
        }
    }
}
