using System.Data.Entity;
using Questionnaire.Core.InterfaceRepository;

namespace Questionnaire.EFData.Repositories
{
    public class Repository : IRepository
    {
        protected DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }
    }
}
