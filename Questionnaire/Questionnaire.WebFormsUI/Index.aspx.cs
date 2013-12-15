using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Questionnaire.Core.Entities;
using Questionnaire.Core.Exceptions;
using Questionnaire.EFData;
using Questionnaire.EFData.EFContext;
using Questionnaire.Services;

namespace Questionnaire.WebFormsUI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void _saveButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                QuestionnaireContext context = new QuestionnaireContext("QuestionnaireConnection");
                UnitOfWork unitOfWork = new UnitOfWork(context);
                MembershipService membershipService = new MembershipService(unitOfWork, unitOfWork);
                QuestionnaireService questionnaireService = new QuestionnaireService(unitOfWork, unitOfWork);
                try
                {
                    Respondent respondent = membershipService.CreateRespondent(_tbxName.Text, _tbxSurname.Text, _tbxPatronymic.Text);
                    questionnaireService.CreateQuestions(int.Parse(_tbxAge.Text), _tbxHobbies.Text, _tbxSeasons.Text, _tbxPetAnimals.Text,
                        _tbxSubjects.Text, _chbxLike.Checked, respondent.Id);
                    unitOfWork.Commit();
                    unitOfWork.Dispose();
                }
                catch (RepositoryException exception)
                {
                    unitOfWork.Dispose();
                    throw;
                }
                Response.Redirect("Congratulations.aspx");
            }
            return;
        }
    }
}