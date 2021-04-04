using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using POC.DTOs;
using POC.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Controllers
{


    [Route("api/productdetails")]
    [ApiController]

    public class ProductDetailsController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductDetailsController(ILogger<UsersController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet] 
        public async Task<ActionResult<List<ProductDetailsDTO>>> Get()
        {
            var product = await context.ProductDetails.AsNoTracking().ToListAsync();
            var productDTOS = mapper.Map<List<ProductDetailsDTO>>(product);
            return productDTOS;
        }

        [HttpGet("{Id:int}", Name = "getDetails")] // api/users/getDetails
        public async Task<ActionResult<ProductDetailsDTO>> Get(int Id)
        {
            var product = await context.ProductDetails.FirstOrDefaultAsync(x => x.product_detail_id == Id);

            if (product == null)
            {
                return NotFound();
            }

            var productDTOS = mapper.Map<ProductDetailsDTO>(product);

            return productDTOS;
        }
        
        [HttpGet("{color}", Name = "getColor")] 
        public async Task<ActionResult<ProductDetailsDTO>> Get(string color)
        {
            var product = await context.ProductDetails.FirstOrDefaultAsync(x => x.color == color);

            if (product == null)
            {
                return NotFound();
            }

            var productDTOS = mapper.Map<ProductDetailsDTO>(product);

            return productDTOS;
        }

        



    }

}
