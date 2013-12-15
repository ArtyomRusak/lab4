using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AR.EPAM.Infrastructure.Guard;
using Questionnaire.Core;
using Questionnaire.Core.Entities;

namespace Questionnaire.Services
{
    public class QuestionnaireService : IService
    {
        #region [Private members]

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public QuestionnaireService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion

        public Question CreateQuestions(int age, string hobbies, string seasonsOfTheYear, string petAnimals, string subjects, bool like, int respondentId)
        {
            var question = new Question
            {
                Age = age,
                Hobbies = hobbies,
                PetAnimals = petAnimals,
                SeasonsOfTheYear = seasonsOfTheYear,
                Subjects = subjects,
                Like = like,
                RespondentId = respondentId
            };

            var questionRepository = _factoryOfRepositories.GetQuestionRepository();
            questionRepository.Create(question);
            _unitOfWork.PreSave();
            return question;
        }

        public void RemoveQuestions(Question question)
        {
            var questionRepository = _factoryOfRepositories.GetQuestionRepository();
            questionRepository.Remove(question);
        }
    }
}
