using DioklecijanovaLegija.Models;
using DioklecijanovaLegija.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace DioklecijanovaLegija.Controllers
{
    public class EventsController : Controller
    {
        private ApplicationDbContext _context;

        public EventsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var events = _context.Events.ToList();

            return View(events);
        }
        public ActionResult Details(int id)
        {
            var upcomingEvent = _context.Events.SingleOrDefault(e => e.Id == id);
            if (upcomingEvent == null)
                return HttpNotFound();

            return View(upcomingEvent);
        }
        public ActionResult Edit(int id)
        {
            var upcomingEvent = _context.Events.SingleOrDefault(e => e.Id == id);

            if (upcomingEvent == null)
                return HttpNotFound();

            var viewModel = new EventFormViewModel
            {
                Event = upcomingEvent
            };

            return View("EventForm", viewModel);

        }
        public ActionResult New()
        {
            var viewModel = new EventFormViewModel
            {
                Event = new Event()
            };

            return View("EventForm", viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Event upcomingEvent)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EventFormViewModel
                {
                    Event = upcomingEvent
                };
                return View("EventForm", viewModel);
            }
            //if (upcomingEvent.Id == 0)
            //{
            //    _context.Events.Add(upcomingEvent);
            //}
            else
            {
                var eventInDb = _context.Events.Single(e => e.Id == upcomingEvent.Id);
                eventInDb.Name = upcomingEvent.Name;
                eventInDb.DateOfEvent = upcomingEvent.DateOfEvent;
                eventInDb.NumberOfMembers = upcomingEvent.NumberOfMembers;
                eventInDb.Id = upcomingEvent.Id;
            }


            _context.SaveChanges();


            return RedirectToAction("Index", "Events");

        }
    }
}
