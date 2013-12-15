using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questionnaire.Core;
using Questionnaire.Core.Entities;

namespace Questionnaire.WebUI.Models.Mappings
{
    public interface IMapper<TEntity, TViewModel>
        where TEntity : Entity
        where TViewModel : ViewModel
    {
        TViewModel MapEntityToViewModel(TEntity entity);
        TEntity MapViewModelToEntity(TViewModel viewModel);
    }
}
