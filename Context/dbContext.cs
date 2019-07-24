
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

        public User getUserById(long id){
            return Users.Include(u => u.McItems).FirstOrDefault(u => u.UserId == id);
        }

        public User addUser(User user){
            Users.Add(user);

            this.SaveChanges();

            return user;
        }

        public void removeUserById(long id){
            User usr = getUserById(id);

            if(usr!=null){
                Users.Remove(usr);
                this.SaveChanges();
            }
        }

        public IQueryable<Item> getAllItems(){
            return Items.Include(i => i.User);
        }

        public Item getItemById(long id){
            return Items.Include(i => i.User).FirstOrDefault(i => i.ItemId == id);
        }

        public void removeItemById(long id){
            Item itm = getItemById(id);

            if(itm!=null){
                Items.Remove(itm);
                this.SaveChanges();
            }
        }

        public Item addItem(Item item){
            Items.Add(item);

            this.SaveChanges();

            return item;
        }
    }
}