using Questionnaire.Core;
using Questionnaire.WebUI.Models;

namespace Questionnaire.WebUI.Mappings
{
    public interface IMapper<TEntity, TViewModel>
        where TEntity : Entity
        where TViewModel : ViewModel
    {
        TViewModel MapEntityToViewModel(TEntity entity);
        TEntity MapViewModelToEntity(TViewModel viewModel);
    }
}
