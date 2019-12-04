using ElectionSystem_RWA.Models;
using ElectionSystem_RWA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectionSystem_RWA.Controllers
{
    public class RegistersController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public RegistersController()
        {
            dbContext = new ApplicationDbContext();
        }
        [HttpGet]
        public ActionResult CandidateChecking()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CandidateChecking(CheckingViewModel checkingViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var candidate = dbContext.Units.FirstOrDefault(c => c.UnitNumber == checkingViewModel.UnitNumber);
            if (candidate == null)
            {
                checkingViewModel.ErrorMessage = "Not a resident of RWA";
                return View("CandidateChecking", checkingViewModel);
            }
            else
            {
                if (candidate.Name == checkingViewModel.Name && checkingViewModel.Age >= 21)
                {
                    return RedirectToAction("Register");
                } 
                else
                {
                    checkingViewModel.ErrorMessage = "Not Eligible to participate in election";
                    return View("CandidateChecking", checkingViewModel);
                }
            }
            
        }
        // GET: Registers
        [HttpGet]
        public ActionResult Register()
        {
            var register = new CandidateRegistrationViewModel();
            ViewBag.QualificationId = ListQualification();
            ViewBag.PostingId = ListPost();
            return View(register);
        }
        [HttpPost]
        public ActionResult Register(CandidateRegistrationViewModel candidate)
        {
            if (!ModelState.IsValid)
            {
                var register = new CandidateRegistrationViewModel();
                ViewBag.QualificationId = ListQualification();
                ViewBag.PostingId = ListPost();
                return View(register);
            }
            if(candidate.PostingId==1)
            {
                var president = new President
                {
                    CandidateName=candidate.CandidateName,
                    CurrentOccupation=candidate.CurrentOccupation,
                    PreviousRWAMember=candidate.PreviousRWAMember,
                    PartOfGovtPoliceNGO=candidate.PartOfGovtPoliceNGO,
                    CriminalRecord=candidate.CriminalRecord,
                    Age=candidate.Age,
                    Gender=candidate.Gender,
                    QualificationId=candidate.QualificationId
                };
                dbContext.Presidents.Add(president);
                dbContext.SaveChanges();
            }
            if (candidate.PostingId == 2)
            {
                var vicepresident = new VicePresident
                {
                    CandidateName = candidate.CandidateName,
                    CurrentOccupation = candidate.CurrentOccupation,
                    PreviousRWAMember = candidate.PreviousRWAMember,
                    PartOfGovtPoliceNGO = candidate.PartOfGovtPoliceNGO,
                    CriminalRecord = candidate.CriminalRecord,
                    Age = candidate.Age,
                    Gender = candidate.Gender,
                    QualificationId = candidate.QualificationId
                };
                dbContext.VicePresident.Add(vicepresident);
                dbContext.SaveChanges();
            }
            if (candidate.PostingId == 3)
            {
                var secretary = new Secretary
                {
                    CandidateName = candidate.CandidateName,
                    CurrentOccupation = candidate.CurrentOccupation,
                    PreviousRWAMember = candidate.PreviousRWAMember,
                    PartOfGovtPoliceNGO = candidate.PartOfGovtPoliceNGO,
                    CriminalRecord = candidate.CriminalRecord,
                    Age = candidate.Age,
                    Gender = candidate.Gender,
                    QualificationId = candidate.QualificationId,


                };
                dbContext.Secretary.Add(secretary);
                dbContext.SaveChanges();
            }
            if (candidate.PostingId == 4)
            {
                var treasurer = new Treasurer
                {
                    CandidateName = candidate.CandidateName,
                    CurrentOccupation = candidate.CurrentOccupation,
                    PreviousRWAMember = candidate.PreviousRWAMember,
                    PartOfGovtPoliceNGO = candidate.PartOfGovtPoliceNGO,
                    CriminalRecord = candidate.CriminalRecord,
                    Age = candidate.Age,
                    Gender = candidate.Gender,
                    QualificationId = candidate.QualificationId,


                };
                dbContext.Treasurer.Add(treasurer);
                dbContext.SaveChanges();
            }
            if (candidate.PostingId == 5)
            {
                var members = new Members
                {
                    CandidateName = candidate.CandidateName,
                    CurrentOccupation = candidate.CurrentOccupation,
                    PreviousRWAMember = candidate.PreviousRWAMember,
                    PartOfGovtPoliceNGO = candidate.PartOfGovtPoliceNGO,
                    CriminalRecord = candidate.CriminalRecord,
                    Age = candidate.Age,
                    Gender = candidate.Gender,
                    QualificationId = candidate.QualificationId,


                };
                dbContext.Members.Add(members);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index","Home");
        }
        [NonAction]
        public IEnumerable<SelectListItem> ListQualification()
        {
            var qualification = (from q in dbContext.qualifications.AsEnumerable()
                                 select new SelectListItem
                                 {
                                     Text = q.QualificationType,
                                     Value = q.Id.ToString()
                                 }).ToList();
            qualification.Insert(0, new SelectListItem { Text = "--Select Qualification--", Value = "0", Selected = true, Disabled = true });
            return qualification;
        }
        [NonAction]
        public IEnumerable<SelectListItem> ListPost()
        {
            var post = (from q in dbContext.postings.AsEnumerable()
                        select new SelectListItem
                        {
                            Text = q.Post,
                            Value = q.Id.ToString()
                        }).ToList();
            post.Insert(0, new SelectListItem { Text = "--Select Posting--", Value = "0", Selected = true, Disabled = true });
            return post;
        }
    }
}