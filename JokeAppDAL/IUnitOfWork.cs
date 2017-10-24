using System;
namespace JokeAppDAL
{
    public interface IUnitOfWork : IDisposable
    {
        //ICustomerRepository CustomerRepository { get; }
       
        int Complete();
    }
}
