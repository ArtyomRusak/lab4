using System;

namespace Questionnaire.Services.Exceptions
{
    public class ServiceException : Exception
    {
        protected ServiceException()
        {

        }

        public ServiceException(string message)
            : base(message)
        {

        }

        public ServiceException(Exception exception)
            : base("See inner exception", exception)
        {

        }
    }
}
