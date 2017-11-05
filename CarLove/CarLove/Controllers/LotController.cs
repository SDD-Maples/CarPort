using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarLove.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarLove
{
 
/*
    [Route("api/[controller]")]
    public class LotController : Controller
    {
        // GET: api/values
        const string database_name = @"./DATA.db";
        static  db = null;

        [HttpGet]
        public JsonResult GetLots()
        {
            try
            {
                if (db == null)
                    db = new SQLiteAsyncConnection(database_name);

                return Json(db.Table<Lot>().ToListAsync().Result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            try
            {
                if (db == null)
                    db = new SQLiteAsyncConnection(database_name);

                return Json(db.Table<Lot>().Where(x => x.ID == id).FirstOrDefaultAsync().Result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public JsonResult GetWest()
        {
            var rand = new Random();
            var Ret = new Lot { ID = 0, CurrentCount = rand.Next(10), Maxsize = 10, Lotname = "West", Location = "Here" };
            return Json(Ret);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }*/
}
