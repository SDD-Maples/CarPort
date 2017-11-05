using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace CarLove.Models
{
    public class Lot
    {
        public int ID;
        public string Lotname;
        public string Location;
        public int Maxsize;
        public int CurrentCount;   
    }
}
