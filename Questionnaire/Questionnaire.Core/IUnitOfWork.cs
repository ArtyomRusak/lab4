using System;

namespace Questionnaire.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();

        void PreSave();
    }
}
