using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Questionnaire.WebUI.Models
{
    public class QuestionRespondentViewModel : ViewModel
    {
        public QuestionViewModel QuestionViewModel { get; set; }
        public RespondentViewModel RespondentViewModel { get; set; }
    }
}