using APIParks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;




namespace APIParks.Controllers
{
    [Route("api/nationals")]
    [ApiController]
    public class NationalsController : ControllerBase
    {
        private APIParksContext _db;
        public NationalsController(APIParksContext db)
        {
            _db = db;
        }
        //GET api/nationals
        [HttpGet]
        public ActionResult<IEnumerable<National>> Get()
        {
            return _db.Nationals.ToList();
        }
        //POST api/nationals
        [HttpPost]
        public void Post([FromBody] National national)
        {
            _db.Nationals.Add(national);
            _db.SaveChanges();
        }
        //PUT api/nationals/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] National national)
        {
            national.NationalId = id;
            _db.Entry(national).State = EntityState.Modified;
            _db.SaveChanges();
        }
        //DELETE api/nationals/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var nationalToDelete = _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
            _db.Nationals.Remove(nationalToDelete);
            _db.SaveChanges();
        }
    }
}