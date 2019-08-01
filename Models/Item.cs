using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using mcShopServer.Serialized;
using mcShopServer.Models;

namespace mcShopServer.Models{
    [Owned]
    public class Item{
        private Item(string mcItemId, string mcItemName, long itemQuantity, string enchantments, long itemPrice){
            McItemId = mcItemId;
            McItemName = mcItemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;

            DateOfCreation = DateTime.Now;

            Enchantments = enchantments;

        }

        public Item(string mcItemId, string mcItemName, long itemQuantity, long itemPrice, User user, string enchantments):
        this(mcItemId, mcItemName, itemQuantity, enchantments, itemPrice){
            User = user;
        }

        public Item(ItemParser itemParser, User user):
        this(itemParser.McItemId, itemParser.McItemName, itemParser.ItemQuantity, itemParser.Enchantments, itemParser.ItemPrice){
            User = user;
        }
        public Item(){}
        
        public long ItemId { get; set; }
        
        [Required]
        public string McItemId {get;set;}
        [Required]
        public string McItemName { get; set; }
        [Required]
        public long ItemQuantity {get;set;}
        public long ItemPrice{get;set;}
        public User User {get;set;}
        public DateTime DateOfCreation{get;set;}
        public string Enchantments{get;set;}

    }
}