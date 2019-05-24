using AktifTelekom.DAL.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktifTelekom.DAL.Uow
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AktifTelekomDbContext _context;
        private IGenericRepository<Users> _usersRepository;
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Customers> _customersRepository;
        private IGenericRepository<A_MAIL> _mailRepository;
        private IGenericRepository<A_YETKI> _yetkiRepository;
        private IGenericRepository<A_YETKIDETAY> _yetkiDetayRepository;

        public UnitOfWork(AktifTelekomDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Users> UsersRepository
        {
            get { return _usersRepository ?? (_usersRepository = new GenericRepository<Users>(_context)); }
        }

        public IGenericRepository<Customers> CustomersRepository
        {
            get { return _customersRepository ?? (_customersRepository = new GenericRepository<Customers>(_context)); }
        }

        public IGenericRepository<User> UserRepository
        {
            get { return _userRepository ?? (_userRepository = new GenericRepository<User>(_context)); }
        }

        public IGenericRepository<A_MAIL> MailRepository
        {
            get { return _mailRepository ?? (_mailRepository = new GenericRepository<A_MAIL>(_context)); }
        }

        public IGenericRepository<A_YETKI> YetkiRepository
        {
            get { return _yetkiRepository ?? (_yetkiRepository = new GenericRepository<A_YETKI>(_context)); }
        }

        public IGenericRepository<A_YETKIDETAY> YetkiDetayRepository
        {
            get { return _yetkiDetayRepository ?? (_yetkiDetayRepository = new GenericRepository<A_YETKIDETAY>(_context)); }
        }

        public async Task Commit()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    _context.Dispose();
                    transaction.Rollback();
                }

            }

        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
