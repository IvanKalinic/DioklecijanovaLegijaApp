using DioklecijanovaLegija.Models;
using DioklecijanovaLegija.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DioklecijanovaLegija.Controllers
{
    public class MembersController : Controller
    {
        private ApplicationDbContext _context;

        public MembersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            //var members = _context.Members.Include(m => m.SoldierType).ToList();

            //return View(members);

            return View();
        }
        public ActionResult Details(int id)
        {
            var member = _context.Members.Include(m => m.SoldierType).SingleOrDefault(m => m.Id == id);
            if (member == null)
                return HttpNotFound();

            return View(member);
        }
        public ActionResult New()
        {
            var soldierTypes = _context.SoldierTypes.ToList();
            var viewModel = new MemberFormViewModel
            {
                Member = new Member(),
                SoldierTypes = soldierTypes
            };
            return View("MemberForm", viewModel);
        }
        public ActionResult Edit(int id)
        {
            var member = _context.Members.SingleOrDefault(m => m.Id == id);
            if (member == null)
                return HttpNotFound();

            var viewModel = new MemberFormViewModel
            {
                Member = member,
                SoldierTypes = _context.SoldierTypes.ToList()
            };
            return View("MemberForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Member member)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MemberFormViewModel
                {
                    Member = member,
                    SoldierTypes = _context.SoldierTypes.ToList()

                };
                return View("MemberForm", viewModel);
            }
            if (member.Id == 0)
                _context.Members.Add(member);
            else
            {
                var memberInDb = _context.Members.Single(m => m.Id == member.Id);  //ne trazimo slucaj kada clan nie pronaden
                memberInDb.Name = member.Name;
                memberInDb.BirthDate = member.BirthDate;
                memberInDb.PhoneNumber = member.PhoneNumber;
                memberInDb.Address = member.Address;
                memberInDb.SoldierTypeId = member.SoldierTypeId;


                //  Mapper.Map(member,memberInDb);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Members");
        }
    }
}
