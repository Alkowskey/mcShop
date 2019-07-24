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
    public class ItemsController : ControllerBase
    {
        private readonly ShoppingContext context;

        public ItemsController(ShoppingContext _context){
            context = _context;
        }

        // GET api/items
        [HttpGet]
        public IQueryable<Item> getItems() => context.getAllItems();

        [HttpPost("getItem")]
        public Item getUserById([FromBody]int id) => context.getItemById(id);
        
    }
}
