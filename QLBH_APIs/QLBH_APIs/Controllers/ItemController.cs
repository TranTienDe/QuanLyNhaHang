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
    public class ItemController : ControllerBase
    {
        private readonly ItemRepository itemRepository;

        public ItemController(ItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return this.itemRepository.GetItems();
        }

    }
}
