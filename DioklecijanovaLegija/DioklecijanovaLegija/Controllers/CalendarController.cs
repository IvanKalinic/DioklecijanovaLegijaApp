using DioklecijanovaLegija.Models;
using System.Linq;
using System.Web.Mvc;

namespace DioklecijanovaLegija.Controllers
{
    public class CalendarController : Controller
    {
        private ApplicationDbContext _context;

        public CalendarController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        //  GET:  /calendar/GetEvents
        public JsonResult GetEvents()
        {
            var events = _context.Calendars.ToList();
            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}
