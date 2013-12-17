using Questionnaire.Core.Entities;
using Questionnaire.WebUI.Models;

namespace Questionnaire.WebUI.Mappings
{
    public class QuestionMapper : IMapper<Question, QuestionViewModel>
    {
        #region Implementation of IMapper<Question,QuestionViewModel>

        public QuestionViewModel MapEntityToViewModel(Question entity)
        {
            var questionViewModel = new QuestionViewModel
            {
                Age = entity.Age,
                Hobbies = entity.Hobbies,
                Like = entity.Like,
                PetAnimals = entity.PetAnimals,
                SeasonsOfTheYear = entity.SeasonsOfTheYear,
                Subjects = entity.Subjects
            };

            return questionViewModel;
        }

        public Question MapViewModelToEntity(QuestionViewModel viewModel)
        {
            var question = new Question
            {
                Age = viewModel.Age,
                Hobbies = viewModel.Hobbies,
                Like = viewModel.Like,
                PetAnimals = viewModel.PetAnimals,
                SeasonsOfTheYear = viewModel.SeasonsOfTheYear,
                Subjects = viewModel.Subjects
            };

            return question;
        }

        #endregion
    }
}