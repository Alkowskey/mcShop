using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using mcShopServer.Serialized;
using mcShopServer.Models;

namespace mcShopServer.Models{
    [Owned]
    public class Item{
        private Item(string mcItemId, string mcItemName, long itemQuantity, string enchantments, long itemPrice, long itemDurability){
            McItemId = mcItemId;
            McItemName = mcItemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
            ItemDurability = itemDurability;

            DateOfCreation = DateTime.Now;

            Enchantments = enchantments;

        }

        public Item(string mcItemId, string mcItemName, long itemQuantity, long itemPrice, User user, string enchantments, long itemDurability):
        this(mcItemId, mcItemName, itemQuantity, enchantments, itemPrice, itemDurability){
            User = user;
        }

        public Item(ItemParser itemParser, User user):
        this(itemParser.McItemId, itemParser.McItemName, itemParser.ItemQuantity, itemParser.Enchantments, itemParser.ItemPrice, itemParser.ItemDurability){
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
        public long ItemDurability {get;set;}
        public long ItemPrice{get;set;}
        public User User {get;set;}
        public DateTime DateOfCreation{get;set;}
        public string Enchantments{get;set;}

    }
}