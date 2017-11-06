using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarLove.Models
{

    public class MapleContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<User> Users { get;set; }
        //public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data.db");
        }
    }

    public class User
    {
        public int ID {get;set;}
        public string Username {get;set;}
        public string Password {get;set;}

        public List<Lot> Favorites {get; set;}
    }
    public class Lot
    {
        public int ID{get; set;}
        public string Lotname{get; set;}
        public string Location{get; set;}
        public int Maxsize{get; set;}
        public int CurrentCount{get; set;}
    }
}
