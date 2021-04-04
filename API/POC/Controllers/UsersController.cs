
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using POC.DTOs;
using POC.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Controllers
{
    [Route("api/users")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UsersController(ILogger<UsersController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet] // api/users
        
        
        public async Task<ActionResult<List<UsersDTO>>> Get()
        {
            var users = await context.Users.AsNoTracking().ToListAsync();
            var UserDTOS = mapper.Map<List<UsersDTO>>(users);
            return UserDTOS;
        }

        [HttpGet("{Id:int}", Name = "getUsers")] // api/users/getUsers
        public async Task<ActionResult<UsersDTO>> Get(int Id)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.user_id == Id);

            if (user == null)
            {
                return NotFound();
            }

            var userDTO = mapper.Map<UsersDTO>(user);

            return userDTO;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] UsersCreationDTO personCreationDTO)
        {
            var person = mapper.Map<Users>(personCreationDTO);
                        
            context.Add(person);
            await context.SaveChangesAsync();
            var personDTO = mapper.Map<UsersDTO>(person);
            return new CreatedAtRouteResult("getPerson", new { id = person.user_id }, personDTO);
        }


        [HttpPut("{id}")]       //update
        public async Task<ActionResult> Put(int id, [FromBody] UsersCreationDTO userCreation)
        {
            var user = mapper.Map<Users>(userCreation);
            user.user_id = id;
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
           return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Users.AnyAsync(x => x.user_id == id);
            if (!exists)
            {
                return NotFound();
            }

            context.Remove(new Users() { user_id = id });
            await context.SaveChangesAsync();

            return NoContent();
        }





    }
}
