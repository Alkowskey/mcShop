using mcShopServer.Models;
using System.Collections.Generic;

namespace mcShopServer.Serialized{
    public class ItemParser{
        
        public long ItemId { get; set; }
        public string McItemId {get;set;}
        public string McItemName { get; set; }
        public long ItemQuantity {get;set;}
        public long ItemPrice{get;set;}
        public string Username {get;set;}
        public string Enchantments{get;set;}
        
    }
}