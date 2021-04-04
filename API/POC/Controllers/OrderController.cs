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
    [Route("api/order")]
    [ApiController]

    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public OrderController(ILogger<OrderController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet("{Id:int}", Name = "getorder")]
        public async Task<ActionResult<OrdersDTO>> Get(int Id)
        {
            var user = await context.Orders.FirstOrDefaultAsync(x => x.order_id == Id);

            if (user == null)
            {
                return NotFound();
            }

            var orderitemDTO = mapper.Map<OrdersDTO>(user);

            return orderitemDTO;
        }
    }
}
