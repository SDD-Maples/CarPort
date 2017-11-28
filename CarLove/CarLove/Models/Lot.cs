using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarLove.Models
{

    //This the acess to get 
    public class MapleContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<User> Users { get;set; }
        //public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   //Specify the file for the database
            optionsBuilder.UseSqlite("Data Source=Data.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //The code bellow sets up the Many to Many relationship between
            // User and Lots
            builder.Entity<FavourLots>()
                .HasKey(t => new{t.LotID, t.UserID});
            
            builder.Entity<FavourLots>()
                .HasOne(lot => lot.Lot)
                .WithMany(f => f.Users)
                .HasForeignKey(lot => lot.LotID);

            builder.Entity<FavourLots>()
                .HasOne(usr => usr.User)
                .WithMany(f => f.Favorites)
                .HasForeignKey(lot => lot.UserID);
        }
    }

    //Users who can log in to view faviortes
    public class User
    {
        public User()
        {
            this.Favorites = new HashSet<FavourLots>();
        }
        public int ID {get;set;}
        public string Username {get;set;}
        //in an Ideal world the Password would be encrypted
        //However for our beta test, we aren't too concerned with security yet
        public string Password {get;set;}

        public virtual ICollection<FavourLots> Favorites {get; set;}
    }
    //Parking Lot
    public class Lot
    {
        public Lot()
        {
            this.Users = new HashSet<FavourLots>();
        }
        public int ID{get; set;}
        public string Lotname{get; set;}
        public string Location{get; set;}
        public int Maxsize{get; set;}
        public int CurrentCount{get; set;}

        public virtual ICollection<FavourLots> Users {get;set;}
        //Src is the URL of the embedded Google Maps 
        public string Src{get;set;}
    }

    //FavourLots is the relationship table between users and lots
    //Allows mutlipul users to favorite mutlipul lots
    public class FavourLots
    {
        public int LotID {get;set;}
        public Lot Lot{get;set;}

        public int UserID{get;set;}
        public User User {get;set;}
    }
}
