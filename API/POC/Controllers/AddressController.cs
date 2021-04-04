using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using POC.DTOs;
using POC.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AddressController(ILogger<AddressController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        
        [HttpGet("{Id:int}", Name = "getAddress")] 
        public async Task<ActionResult<AddressDTO>> Get(int Id)
        {
            var user = await context.Address
                .Where(x => x.user_id == Id).ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            var userDTO = mapper.Map<AddressDTO>(user);

            return userDTO;
        }
    }
}
