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
        [HttpGet("items")]
        public IQueryable<Item> getItems()
        {
            User user = context.getUserById(1);

            Item item = new Item("Gold", "Gold", 19, 33, user);


            context.addItem(item);

            context.SaveChanges();

            return context.getAllItems();
        }
    }
}
