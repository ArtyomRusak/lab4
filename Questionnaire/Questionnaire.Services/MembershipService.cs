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
    public class MembershipService : IService
    {
        #region [Private members]

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public MembershipService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion

        public Respondent CreateRespondent(string name, string surname, string patronymic)
        {
            var respondent = new Respondent
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic
            };

            var respondentRepository = _factoryOfRepositories.GetRespondentRepository();
            respondentRepository.Create(respondent);
            _unitOfWork.PreSave();
            return respondent;
        }

        public void RemoveRespondent(Respondent respondent)
        {
            var respondentRepository = _factoryOfRepositories.GetRespondentRepository();
            respondentRepository.Remove(respondent);
        }
    }
}
