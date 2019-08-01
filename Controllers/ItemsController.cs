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
        public Item getItemById([FromBody]IdParser idParser) => context.getItemById(idParser.id);

        [HttpGet("getItems")]
        public IQueryable<Item> getItemByUsername([FromQuery]string username) => context.getItemsByUsername(username);

        [HttpPost("addItem")]
        public Item addItem([FromBody]ItemParser itemParser) { 
            User user = context.getUserByUsername(itemParser.Username);
            if(user == null){
                user = new User();
                user.McUserId = itemParser.Username;
                user.McUsername = itemParser.Username;

                context.SaveChanges();
            }

            return context.addItem(new Item(itemParser, context.getUserByUsername(itemParser.Username)));
        }

        [HttpPost("removeItem")]
        public void removeItem([FromBody]IdParser idParser) {
            context.removeItemById(idParser.id);
        }

        [HttpGet("removeAll")]

        public void removeAllItems(){
            context.removeAllItems();
        }
        
    }
}
