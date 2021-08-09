using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository categoryRepository;
        private readonly ILogger<WeatherForecastController> logger;

        public CategoryController(CategoryRepository categoryRepository, ILogger<WeatherForecastController> logger)
        {
            this.categoryRepository = categoryRepository;
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            try
            {
                return this.categoryRepository.GetCategories();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
