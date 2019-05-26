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
        private IGenericRepository<A_MAIL> _mailRepository;
        private IGenericRepository<A_MODUL> _modulRepository;
        private IGenericRepository<A_MUSTERIMODUL> _musteriModulRepository;
        private IGenericRepository<A_YETKI> _yetkiRepository;
        private IGenericRepository<A_YETKIDETAY> _yetkiDetayRepository;
        private IGenericRepository<AGENT> _agentRepository;
        private IGenericRepository<AgentCallLogs> _agentCallLogsRepository;
        private IGenericRepository<AgentGroupHierarchies> _agentGroupHierarchiesRepository;
        private IGenericRepository<AgentGroupHistories> _agentGroupHistoriesRepository;
        private IGenericRepository<AGENTGRUP> _agentGroupRepository;
        private IGenericRepository<AgentGroups> _agentGroupsRepository;
        private IGenericRepository<AgentProcesses> _agentProcessesRepository;
        private IGenericRepository<AgentSetting> _agentSettingRepository;
        private IGenericRepository<AgentStatusLogs> _agentStatusLogsRepository;
        private IGenericRepository<AgentTimeout> _agentTimeoutRepository;
        private IGenericRepository<Appointments> _appointmentsRepository;
        private IGenericRepository<AssignDetails> _assignDetailsRepository;
        private IGenericRepository<CallHistories> _callHistoriesRepository;
        private IGenericRepository<CallResults> _callResultsRepository;
        private IGenericRepository<CallStatus> _callStatusRepository;
        private IGenericRepository<CallStatusLogs> _callStatusLogsRepository;
        private IGenericRepository<CallTypes> _callTypesRepository;
        private IGenericRepository<cars> _carsRepository;
        private IGenericRepository<CheckSendCalls> _checkSendCallsRepository;
        private IGenericRepository<Cities> _citiesRepository;
        private IGenericRepository<Customers> _customersRepository;
        private IGenericRepository<Users> _usersRepository;
        private IGenericRepository<User> _userRepository;
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

        public IGenericRepository<A_MODUL> ModulRepository
        {
            get { return _modulRepository ?? (_modulRepository = new GenericRepository<A_MODUL>(_context)); }
        }

        public IGenericRepository<A_MUSTERIMODUL> MusteriModulRepository
        {
            get { return _musteriModulRepository ?? (_musteriModulRepository = new GenericRepository<A_MUSTERIMODUL>(_context)); }
        }

        public IGenericRepository<AGENT> AgentRepository
        {
            get { return _agentRepository ?? (_agentRepository = new GenericRepository<AGENT>(_context)); }
        }

        public IGenericRepository<AgentCallLogs> AgentCallLogsRepository
        {
            get { return _agentCallLogsRepository ?? (_agentCallLogsRepository = new GenericRepository<AgentCallLogs>(_context)); }
        }

        public IGenericRepository<AgentGroupHierarchies> AgentGroupHierarchiesRepository
        {
            get { return _agentGroupHierarchiesRepository ?? (_agentGroupHierarchiesRepository = new GenericRepository<AgentGroupHierarchies>(_context)); }
        }

        public IGenericRepository<AgentGroupHistories> AgentGroupHistoriesRepository
        {
            get { return _agentGroupHistoriesRepository ?? (_agentGroupHistoriesRepository = new GenericRepository<AgentGroupHistories>(_context)); }
        }

        public IGenericRepository<AGENTGRUP> AgentGroupRepository
        {
            get { return _agentGroupRepository ?? (_agentGroupRepository = new GenericRepository<AGENTGRUP>(_context)); }
        }

        public IGenericRepository<AgentGroups> AgentGroupsRepository
        {
            get { return _agentGroupsRepository ?? (_agentGroupsRepository = new GenericRepository<AgentGroups>(_context)); }
        }

        public IGenericRepository<AgentProcesses> AgentProcessesRepository
        {
            get { return _agentProcessesRepository ?? (_agentProcessesRepository = new GenericRepository<AgentProcesses>(_context)); }
        }

        public IGenericRepository<AgentSetting> AgentSettingRepository
        {
            get { return _agentSettingRepository ?? (_agentSettingRepository = new GenericRepository<AgentSetting>(_context)); }
        }

        public IGenericRepository<AgentStatusLogs> AgentStatusLogsRepository
        {
            get { return _agentStatusLogsRepository ?? (_agentStatusLogsRepository = new GenericRepository<AgentStatusLogs>(_context)); }
        }

        public IGenericRepository<AgentTimeout> AgentTimeoutRepository
        {
            get { return _agentTimeoutRepository ?? (_agentTimeoutRepository = new GenericRepository<AgentTimeout>(_context)); }
        }

        public IGenericRepository<Appointments> AppointmentsRepository
        {
            get { return _appointmentsRepository ?? (_appointmentsRepository = new GenericRepository<Appointments>(_context)); }
        }

        public IGenericRepository<AssignDetails> AssignDetailsRepository
        {
            get { return _assignDetailsRepository ?? (_assignDetailsRepository = new GenericRepository<AssignDetails>(_context)); }
        }

        public IGenericRepository<CallHistories> CallHistoriesRepository
        {
            get { return _callHistoriesRepository ?? (_callHistoriesRepository = new GenericRepository<CallHistories>(_context)); }
        }

        public IGenericRepository<CallResults> CallResultsRepository
        {
            get { return _callResultsRepository ?? (_callResultsRepository = new GenericRepository<CallResults>(_context)); }
        }

        public IGenericRepository<CallStatus> CallStatusRepository
        {
            get { return _callStatusRepository ?? (_callStatusRepository = new GenericRepository<CallStatus>(_context)); }
        }

        public IGenericRepository<CallStatusLogs> CallStatusLogsRepository
        {
            get { return _callStatusLogsRepository ?? (_callStatusLogsRepository = new GenericRepository<CallStatusLogs>(_context)); }
        }

        public IGenericRepository<CallTypes> CallTypesRepository
        {
            get { return _callTypesRepository ?? (_callTypesRepository = new GenericRepository<CallTypes>(_context)); }
        }

        public IGenericRepository<cars> CarsRepository
        {
            get { return _carsRepository ?? (_carsRepository = new GenericRepository<cars>(_context)); }
        }

        public IGenericRepository<CheckSendCalls> CheckSendCallsRepository
        {
            get { return _checkSendCallsRepository ?? (_checkSendCallsRepository = new GenericRepository<CheckSendCalls>(_context)); }
        }

        public IGenericRepository<Cities> CitiesRepository
        {
            get { return _citiesRepository ?? (_citiesRepository = new GenericRepository<Cities>(_context)); }
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
