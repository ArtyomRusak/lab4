using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Questionnaire.WebUI.Models
{
    public class RespondentViewModel : ViewModel
    {
        [Required(ErrorMessage = "Name required.")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(30)]
        public string Patronymic { get; set; }
    }
}