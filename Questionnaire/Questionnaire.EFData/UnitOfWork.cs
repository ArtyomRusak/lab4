﻿using System;
using System.Data.Entity;
using Questionnaire.Core;
using Questionnaire.Core.Exceptions;

namespace Questionnaire.EFData
{
    public class UnitOfWork : IUnitOfWork, IRepositoryFactory
    {
        #region [Private members]

        private bool _disposed;
        private bool _isTransactionActive;
        private readonly DbContext _context;
        private DbContextTransaction _transaction;

        #endregion


        #region [Ctor's]

        public UnitOfWork(DbContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
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
                }
                catch (Exception e)
                {
                    _transaction.Rollback();
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
                throw new RepositoryException(e.Message);
            }
        }

        public void Rollback()
        {
            if (_isTransactionActive && !_disposed)
            {
                _transaction.Rollback();
            }
        }

        public void PreSave()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
