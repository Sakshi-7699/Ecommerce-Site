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
    [Route("api/cart")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CartController(ILogger<CartController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet("{Id:int}", Name = "getCart")] 
        public async Task<ActionResult<CartDTO>> Get(int Id)
        {
            var user = await context.Cart.FirstOrDefaultAsync(x => x.user_id == Id);

            if (user == null)
            {
                return NotFound();
            }

            var userDTO = mapper.Map<CartDTO>(user);

            return userDTO;
        }
    }
}
