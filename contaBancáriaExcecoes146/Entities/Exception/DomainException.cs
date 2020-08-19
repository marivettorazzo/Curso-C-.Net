using System;


namespace contaBancáriaExcecoes146.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException (string message): base(message)
        {
        }
    }
}
