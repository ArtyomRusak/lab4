using Questionnaire.Core.Entities;
using Questionnaire.Core.InterfaceRepository;

namespace Questionnaire.Core
{
    public interface IRepositoryFactory
    {
        IRepository<Respondent, int> GetRespondentRepository();
        IRepository<Question, int> GetQuestionRepository();
    }
}
