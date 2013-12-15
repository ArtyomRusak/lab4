using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Questionnaire.Core.Entities;
using Questionnaire.Core.Exceptions;
using Questionnaire.EFData;
using Questionnaire.EFData.EFContext;
using Questionnaire.Services;
using Questionnaire.WebUI.Models;

namespace Questionnaire.WebUI.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        public ActionResult Index(int? id)
        {
            QuestionRespondentViewModel model = new QuestionRespondentViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(QuestionRespondentViewModel model)
        {
            Respondent respondent;
            if (ModelState.IsValid)
            {
                QuestionnaireContext context = new QuestionnaireContext("QuestionnaireConnection");
                UnitOfWork unitOfWork = new UnitOfWork(context);
                MembershipService membershipService = new MembershipService(unitOfWork, unitOfWork);
                QuestionnaireService questionnaireService = new QuestionnaireService(unitOfWork, unitOfWork);
                var questionModel = model.QuestionViewModel;
                var respondentModel = model.RespondentViewModel;
                try
                {
                    respondent = membershipService.CreateRespondent(respondentModel.Name, respondentModel.Surname, respondentModel.Patronymic);
                    questionnaireService.CreateQuestions(questionModel.Age, questionModel.Hobbies, questionModel.SeasonsOfTheYear, questionModel.PetAnimals,
                        questionModel.Subjects, questionModel.Like, respondent.Id);
                    unitOfWork.Commit();
                    unitOfWork.Dispose();
                }
                catch (RepositoryException)
                {
                    unitOfWork.Dispose();
                    throw;
                }
                throw new Exception("Try");
                return RedirectToAction("Congratulations", new { id = respondent.Name });
            }
            else
            {
                ModelState.AddModelError("Error", errorMessage: "Something was wrong!");
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Congratulations(string id)
        {
            ViewBag.Name = id;
            return View();
        }
    }
}