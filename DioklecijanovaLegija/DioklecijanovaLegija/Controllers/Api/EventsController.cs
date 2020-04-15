using AutoMapper;
using DioklecijanovaLegija.Dtos;
using DioklecijanovaLegija.Models;
using System;
using System.Linq;
using System.Web.Http;

namespace DioklecijanovaLegija.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/events
        public IHttpActionResult GetEvents()
        {
            return Ok(_context.Events.ToList().Select(Mapper.Map<Event, EventDto>));
        }
        // GET /api/events/1
        public IHttpActionResult GetEvent(int id)
        {
            var upcomingEvent = _context.Events.SingleOrDefault(c => c.Id == id);

            if (upcomingEvent == null)
                return NotFound();

            return Ok(Mapper.Map<Event, EventDto>(upcomingEvent));
        }

        //POST /api/events
        [HttpPost]
        public IHttpActionResult CreateEvent(EventDto eventDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var upcpomingEvent = Mapper.Map<EventDto, Event>(eventDto);
            _context.Events.Add(upcpomingEvent);
            _context.SaveChanges();

            eventDto.Id = upcpomingEvent.Id;
            return Created(new Uri(Request.RequestUri + "/" + upcpomingEvent.Id), eventDto);
        }

        //PUT /api/events/1
        [HttpPut]
        public IHttpActionResult UpdateEvent(int id, EventDto eventDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var eventInDb = _context.Events.SingleOrDefault(c => c.Id == id);

            if (eventInDb == null)
                return NotFound();

            Mapper.Map(eventDto, eventInDb);

            _context.SaveChanges();

            return Ok();
        }
        // DELETE /api/event/1
        [HttpDelete]
        public IHttpActionResult DeleteEvent(int id)
        {
            var eventInDb = _context.Events.SingleOrDefault(c => c.Id == id);

            if (eventInDb == null)
                return NotFound();

            _context.Events.Remove(eventInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
