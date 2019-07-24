using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using mcShopServer.Serialized;

namespace mcShopServer.Models{
    public class Item{
        private Item(string mcItemId, string mcItemName, long itemQuantity, long itemPrice){
            McItemId = mcItemId;
            McItemName = mcItemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;

            DateOfCreation = DateTime.Now;

        }

        public Item(string mcItemId, string mcItemName, long itemQuantity, long itemPrice, User user):
        this(mcItemId, mcItemName, itemQuantity, itemPrice){
            User = user;
        }

        public Item(ItemParser itemParser, User user):this(itemParser.McItemId, itemParser.McItemName, itemParser.ItemQuantity, itemParser.ItemPrice){
            User = user;
        }
        
        public long ItemId { get; set; }
        
        [Required]
        public string McItemId {get;set;}
        [Required]
        public string McItemName { get; set; }
        [Required]
        public long ItemQuantity {get;set;}
        [Required]
        public long ItemPrice{get;set;}
        public User User {get;set;}
        public DateTime DateOfCreation{get;set;}

    }
}