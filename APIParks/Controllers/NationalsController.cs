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
        //GET api/nationals?nationalparkname={nationalparkname}&nationalparklocation={nationalParkLocation}
        [HttpGet]
        public ActionResult<IEnumerable<National>> Get(string nationalParkName, string nationalParkLocation)
        {
            var query = _db.Nationals.AsQueryable();
            if (nationalParkName != null)
            {
                query = query.Where(entry => entry.NationalParkName == nationalParkName);
            }
            if (nationalParkLocation != null)
            {
                query = query.Where(entry => entry.NationalParkLocation == nationalParkLocation);
            }
            return query.ToList();
        }
        // GET api/nationals/{id}
        [HttpGet("{id}")]
        public ActionResult<National> GetById(int id)
        {
            return _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
        }
        // GET api/nationals/state?nationalparklocation={state}
        [HttpGet("state")]
        public ActionResult<IEnumerable<National>> GetParkByLocation(string nationalParkLocation)
        {
            var query = _db.Nationals.AsQueryable();
            query = query.Where(entry => entry.NationalParkLocation == nationalParkLocation);
            return query.ToList();
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