using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POC.DTOs;
using Microsoft.EntityFrameworkCore;
using POC.Helpers;
namespace POC.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductsController(ILogger<ProductsController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductsDTO>>> Get([FromQuery] PaginationDTO pagination)
        {
            var queryable = context.Products.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, pagination.RecordsPerPage);
            var product = await queryable.Paginate(pagination).ToListAsync();
            return mapper.Map<List<ProductsDTO>>(product);
        }

        [HttpGet("{Id:int}", Name = "getProducts")] // api/users/getUsers
        public async Task<ActionResult<ProductsDTO>> Get(int Id)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.product_id == Id);

            if (product == null)
            {
                return NotFound();
            }

            var ProductsDTOs = mapper.Map<ProductsDTO>(product);

            return ProductsDTOs;
        }
    }
}
