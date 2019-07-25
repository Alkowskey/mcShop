using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using mcShopServer.Context;
using mcShopServer.Models;
using mcShopServer.Serialized;

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
        public Item getUserById([FromBody]long id) => context.getItemById(id);

        [HttpPost("addItem")]
        public Item addItem([FromBody]ItemParser itemParser) => context.addItem(new Item(itemParser, context.getUserByUsername(itemParser.Username)));

        [HttpDelete("removeItem")]
        public void removeItem([FromBody]long id) {
            context.removeItemById(id);
        }

        [HttpGet("removeAll")]

        public void removeAllItems(){
            context.removeAllItems();
        }
        
    }
}
