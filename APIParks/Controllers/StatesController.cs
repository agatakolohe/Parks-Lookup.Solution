using APIParks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace APIParks.Controllers
{
    [Route("api/states")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private APIParksContext _db;
        public StatesController(APIParksContext db)
        {
            _db = db;
        }
        //GET api/states
        //GET api/states?stateparkname={stateparkname}&stateparklocation={stateParkLocation}
        [HttpGet]
        public ActionResult<IEnumerable<State>> Get(string stateParkName, string stateParkLocation)
        {
            var query = _db.States.AsQueryable();
            if (stateParkName != null)
            {
                query = query.Where(entry => entry.StateParkName == stateParkName);
            }
            if (stateParkLocation != null)
            {
                query = query.Where(entry => entry.StateParkLocation == stateParkLocation);
            }
            return query.ToList();
        }
        // GET api/states/{id}
        [HttpGet("{id}")]
        public ActionResult<State> GetById(int id)
        {
            return _db.States.FirstOrDefault(entry => entry.StateId == id);
        }
        // GET api/states/state?stateparklocation={state}
        [HttpGet("state")]
        public ActionResult<IEnumerable<State>> GetParkByLocation(string stateParkLocation)
        {
            var query = _db.States.AsQueryable();
            query = query.Where(entry => entry.StateParkLocation == stateParkLocation);
            return query.ToList();
        }

        //POST api/states
        [HttpPost]
        public void Post([FromBody] State state)
        {
            _db.States.Add(state);
            _db.SaveChanges();
        }
        //PUT api/states/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State state)
        {
            state.StateId = id;
            _db.Entry(state).State = EntityState.Modified;
            _db.SaveChanges();
        }
        //DELETE api/states/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var stateToDelete = _db.States.FirstOrDefault(entry => entry.StateId == id);
            _db.States.Remove(stateToDelete);
            _db.SaveChanges();
        }
    }
}