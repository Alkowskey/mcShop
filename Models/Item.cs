using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using mcShopServer.Serialized;
using mcShopServer.Models;

namespace mcShopServer.Models{
    [Owned]
    public class Item{
        private Item(string mcItemId, string mcItemName, long itemQuantity){
            McItemId = mcItemId;
            McItemName = mcItemName;
            ItemQuantity = itemQuantity;

            DateOfCreation = DateTime.Now;

        }

        public Item(string mcItemId, string mcItemName, long itemQuantity, Item itemPrice, User user):
        this(mcItemId, mcItemName, itemQuantity){
            User = user;
            ItemPrice = itemPrice;
        }

        public Item(ItemParser itemParser, User user, Item itemPrice):this(itemParser.McItemId, itemParser.McItemName, itemParser.ItemQuantity){
            User = user;
            ItemPrice = itemPrice;
        }

        public Item(){}
        
        public long ItemId { get; set; }
        
        [Required]
        public string McItemId {get;set;}
        [Required]
        public string McItemName { get; set; }
        [Required]
        public long ItemQuantity {get;set;}
        public Item ItemPrice{get;set;}
        public User User {get;set;}
        public DateTime DateOfCreation{get;set;}

    }
}