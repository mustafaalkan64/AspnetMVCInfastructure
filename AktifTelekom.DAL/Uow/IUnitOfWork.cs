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
        IGenericRepository<A_MAIL> MailRepository { get; }
        IGenericRepository<A_MODUL> ModulRepository { get; }
        IGenericRepository<A_MUSTERIMODUL> MusteriModulRepository { get; }
        IGenericRepository<A_YETKI> YetkiRepository { get; }
        IGenericRepository<A_YETKIDETAY> YetkiDetayRepository { get; }
        IGenericRepository<AGENT> AgentRepository { get; }
        IGenericRepository<AgentCallLogs> AgentCallLogsRepository { get; }
        IGenericRepository<AgentGroupHierarchies> AgentGroupHierarchiesRepository { get; }
        IGenericRepository<AgentGroupHistories> AgentGroupHistoriesRepository { get; }
        IGenericRepository<AGENTGRUP> AgentGroupRepository { get; }
        IGenericRepository<AgentGroups> AgentGroupsRepository { get; }
        IGenericRepository<AgentProcesses> AgentProcessesRepository { get; }
        IGenericRepository<AgentSetting> AgentSettingRepository { get; }
        IGenericRepository<AgentStatusLogs> AgentStatusLogsRepository { get; }
        IGenericRepository<AgentTimeout> AgentTimeoutRepository { get; }
        IGenericRepository<Appointments> AppointmentsRepository { get; }
        IGenericRepository<AssignDetails> AssignDetailsRepository { get; }
        IGenericRepository<CallHistories> CallHistoriesRepository { get; }
        IGenericRepository<CallResults> CallResultsRepository { get; }
        IGenericRepository<CallStatus> CallStatusRepository { get; }
        IGenericRepository<CallStatusLogs> CallStatusLogsRepository { get; }
        IGenericRepository<CallTypes> CallTypesRepository { get; }
        IGenericRepository<cars> CarsRepository { get; }
        IGenericRepository<CheckSendCalls> CheckSendCallsRepository { get; }
        IGenericRepository<Cities> CitiesRepository { get; }
        IGenericRepository<Customers> CustomersRepository { get; }
        IGenericRepository<Users> UsersRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        Task Commit();
    }
}
