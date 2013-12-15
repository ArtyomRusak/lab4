using System;
using System.Data.Entity;
using Questionnaire.Core;
using Questionnaire.Core.Entities;
using Questionnaire.Core.Exceptions;
using Questionnaire.Core.InterfaceRepository;
using Questionnaire.EFData.Repositories;

namespace Questionnaire.EFData
{
    public class UnitOfWork : IUnitOfWork, IRepositoryFactory
    {
        #region [Private members]

        private bool _disposed;
        private bool _isTransactionActive;
        private readonly DbContext _context;
        private readonly DbContextTransaction _transaction;
        private IRepository<Respondent, int> _respondentRepository;
        private IRepository<Question, int> _questionRepository; 

        #endregion


        #region [Ctor's]

        public UnitOfWork(DbContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
            _isTransactionActive = true;
        }

        #endregion


        #region Implementation of IDisposable

        public void Dispose()
        {
            if (_isTransactionActive)
            {
                try
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
                catch (Exception e)
                {
                    _transaction.Rollback();
                    _isTransactionActive = false;
                    throw new RepositoryException(e);
                }
            }
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }

        #endregion


        #region Implementation of IUnitOfWork

        public void Commit()
        {
            try
            {
                if (_isTransactionActive && !_disposed)
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
                throw new RepositoryException(e.Message);
            }
        }

        public void Rollback()
        {
            if (_isTransactionActive && !_disposed)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
            }
        }

        public void PreSave()
        {
            _context.SaveChanges();
        }

        #endregion

        #region Implementation of IRepositoryFactory

        public IRepository<Respondent, int> GetRespondentRepository()
        {
            return _respondentRepository ?? (_respondentRepository = new Repository<Respondent, int>(_context));
        }

        public IRepository<Question, int> GetQuestionRepository()
        {
            return _questionRepository ?? (_questionRepository = new Repository<Question, int>(_context));
        }

        #endregion
    }
}
