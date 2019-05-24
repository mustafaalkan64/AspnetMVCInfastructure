using AktifTelekom.DAL.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktifTelekom.DAL.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Users> UsersRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<A_MAIL> MailRepository { get; }
        IGenericRepository<Customers> CustomersRepository { get; }
        IGenericRepository<A_YETKI> YetkiRepository { get; }
        IGenericRepository<A_YETKIDETAY> YetkiDetayRepository { get; }
        Task Commit();
    }
}
