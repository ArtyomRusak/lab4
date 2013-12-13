using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Core.Entities
{
    public class Question : Entity<int>
    {
        public int Age { get; set; }
        public string Hobbies { get; set; }
        public string SeasonsOfTheYear { get; set; }
        public string PetAnimals { get; set; }
        public string Subjects { get; set; }
        public bool Like { get; set; }
        public int RespondentId { get; set; }
        public Respondent Respondent { get; set; }
    }
}
