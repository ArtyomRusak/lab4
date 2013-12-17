using AR.EPAM.Infrastructure.Guard;
using Questionnaire.Core.Entities;
using Questionnaire.WebUI.Models;

namespace Questionnaire.WebUI.Mappings
{
    public class RespondentMapper : IMapper<Respondent, RespondentViewModel>
    {
        #region Implementation of IMapper<Respondent,RespondentViewModel>

        public RespondentViewModel MapEntityToViewModel(Respondent entity)
        {
            Guard.AgainstNullReference(entity, "entity");

            var respondentViewModel = new RespondentViewModel
            {
                Name = entity.Name,
                Surname = entity.Surname,
                Patronymic = entity.Patronymic
            };

            return respondentViewModel;
        }

        public Respondent MapViewModelToEntity(RespondentViewModel viewModel)
        {
            Guard.AgainstNullReference(viewModel, "viewModel");

            var respondent = new Respondent
            {
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                Patronymic = viewModel.Patronymic
            };

            return respondent;
        }

        #endregion
    }
}