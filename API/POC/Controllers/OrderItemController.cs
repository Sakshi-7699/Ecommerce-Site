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


    [Route("api/orderitem")]
    [ApiController]

    public class OrderItemController : ControllerBase
    {
        private readonly ILogger<OrderItemController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public OrderItemController(ILogger<OrderItemController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet("{Id:int}", Name = "getitem")]
        public async Task<ActionResult<OrderItemDTO>> Get(int Id)
        {
            var user = await context.OrderItem.FirstOrDefaultAsync(x => x.order_item_id == Id);

            if (user == null)
            {
                return NotFound();
            }

            var orderitemDTO = mapper.Map<OrderItemDTO>(user);

            return orderitemDTO;
        }
    }

}
