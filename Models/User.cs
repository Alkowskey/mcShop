using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using mcShopServer.Models;
using Microsoft.EntityFrameworkCore;

namespace mcShopServer.Models{
    [Owned]
    public class User{

        [Required]
        public long UserId { get; set; }
        [Required]
        public string McUserId {get;set;}
        [Required]
        public string McUsername { get; set; }
        public ICollection<Item> McItems {get;} = new List<Item>();
    }
}