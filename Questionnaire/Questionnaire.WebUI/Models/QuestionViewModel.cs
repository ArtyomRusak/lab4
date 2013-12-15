using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Questionnaire.WebUI.Models
{
    public class QuestionViewModel : ViewModel
    {
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Write about your hobbies")]
        public string Hobbies { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Your favorite seasons of the year")]
        public string SeasonsOfTheYear { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Favorite animals? Do you have one?")]
        public string PetAnimals { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name = "Your favorite subjects in school/university")]
        public string Subjects { get; set; }
        [Required]
        [Display(Name = "Do you like our questionnaire?")]
        public bool Like { get; set; }
    }
}