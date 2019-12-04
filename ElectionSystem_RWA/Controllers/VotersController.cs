using ElectionSystem_RWA.Models;
using ElectionSystem_RWA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace ElectionSystem_RWA.Controllers
{
    public class VotersController : Controller
    {
        private ApplicationDbContext dbContext;
        public VotersController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Voters
      
            [HttpGet]
        public ActionResult Ballot()
        {
            var viewModel = new PostingViewModel();
            viewModel.President = dbContext.Presidents.Include(p=>p.Qualification).ToList();
            viewModel.VicePresident=dbContext.VicePresident.Include(p => p.Qualification).ToList();
            viewModel.Secretary= dbContext.Secretary.Include(p => p.Qualification).ToList();
            viewModel.Treasurer = dbContext.Treasurer.Include(p => p.Qualification).ToList();
            viewModel.Members = dbContext.Members.Include(p => p.Qualification).ToList();
            
            return View(viewModel);
        }
       
        public ActionResult CountVote(int id)
        {
           
            var president=dbContext.Presidents.FirstOrDefault(p => p.Id == id);
            president.Vote++;
            dbContext.SaveChanges();
            //count++;
            return View("Thank");
        }
        public ActionResult Result()
        {
            var president = dbContext.Presidents.ToList();

            //ViewBag.president = president;

            return View(president);
        }
        public ActionResult Winner()
        {
            var president = dbContext.Presidents.OrderByDescending(p=>p.Vote).First();
            return View(president);
        }
        //[HttpPost]
        //public ActionResult Ballot(PostingViewModel voteFromView)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        var viewModel = new PostingViewModel();
        //        viewModel.President = dbContext.Presidents.Include(p => p.Qualification).ToList();
        //        viewModel.VicePresident = dbContext.VicePresident.Include(p => p.Qualification).ToList();
        //        viewModel.Secretary = dbContext.Secretary.Include(p => p.Qualification).ToList();
        //        viewModel.Treasurer = dbContext.Treasurer.Include(p => p.Qualification).ToList();
        //        viewModel.Members = dbContext.Members.Include(p => p.Qualification).ToList();
        //        return View(viewModel);
        //    }
        //   voteFromView.President.
        //    dbContext.Presidents.Add();
        //    return View("Thank");
        //}
       
        public ActionResult Thank()
        {
            return View();
        }
    }
}