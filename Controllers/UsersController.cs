using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using mcShopServer.Context;
using mcShopServer.Models;

namespace mcShopServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ShoppingContext context;

        public UsersController(ShoppingContext _context){
            context = _context;
        }

        // GET api/users
        [HttpGet]
        public IQueryable<User> Get() => context.getAllUsers();

        [HttpPost("getUser")]
        public User getUserById([FromBody]long id) => context.getUserById(id);

        [HttpPost("addUser")]
        public User addUser([FromBody]User user) => context.addUser(user);

        [HttpDelete("removeUser")]
        public void removeUser([FromBody]long id) {
            context.removeUserById(id);
        }


    }
}
