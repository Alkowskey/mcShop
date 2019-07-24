
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;

using mcShopServer.Models;



namespace mcShopServer.Context
{
    public class ShoppingContext : DbContext
    {
        private DbSet<Item> Items { get; set; }

        private DbSet<User> Users { get; set; }

        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base (options){
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.McItems)
                .WithOne(i => i.User);
        }

        public IQueryable<User> getAllUsers(){
            return Users.Include(u => u.McItems);
        }

        public User getUserById(int id){
            return Users.Include(u => u.McItems).FirstOrDefault(u => u.UserId == id);
        }

        public User addUser(User user){
            Users.Add(user);

            this.SaveChanges();

            return user;
        }

        public IQueryable<Item> getAllItems(){
            return Items.Include(i => i.User);
        }

        public Item getItemById(int id){
            return Items.Include(i => i.User).FirstOrDefault(i => i.ItemId == id);
        }

        public Item addItem(Item item){
            Items.Add(item);

            return item;
        }
    }
}