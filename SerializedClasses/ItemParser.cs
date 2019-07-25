using mcShopServer.Models;

namespace mcShopServer.Serialized{
    public class ItemParser{
        
        public long ItemId { get; set; }
        public string McItemId {get;set;}
        public string McItemName { get; set; }
        public long ItemQuantity {get;set;}
        public Item ItemPrice{get;set;}
        public string Username {get;set;}
        
    }
}