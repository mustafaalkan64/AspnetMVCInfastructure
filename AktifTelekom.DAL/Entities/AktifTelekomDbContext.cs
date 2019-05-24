namespace AktifTelekom.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AktifTelekomDbContext : DbContext
    {
        public AktifTelekomDbContext()
            : base("name=CustomerDB")
        {
        }

        public virtual DbSet<A_MAIL> A_MAIL { get; set; }
        public virtual DbSet<A_MODUL> A_MODUL { get; set; }
        public virtual DbSet<A_MUSTERIMODUL> A_MUSTERIMODUL { get; set; }
        public virtual DbSet<A_YETKI> A_YETKI { get; set; }
        public virtual DbSet<A_YETKIDETAY> A_YETKIDETAY { get; set; }
        public virtual DbSet<AGENT> AGENT { get; set; }
        public virtual DbSet<AGENTGRUP> AGENTGRUP { get; set; }
        public virtual DbSet<AgentSetting> AgentSetting { get; set; }
        public virtual DbSet<AgentTimeout> AgentTimeout { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<AssignDetails> AssignDetails { get; set; }
        public virtual DbSet<CallHistories> CallHistories { get; set; }
        public virtual DbSet<ContactDesc> ContactDesc { get; set; }
        public virtual DbSet<ContactGroup> ContactGroup { get; set; }
        public virtual DbSet<ContactGroup2> ContactGroup2 { get; set; }
        public virtual DbSet<ContactImportance> ContactImportance { get; set; }
        public virtual DbSet<ContactMails> ContactMails { get; set; }
        public virtual DbSet<ContactRandevu> ContactRandevu { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<CRM_Log> CRM_Log { get; set; }
        public virtual DbSet<ExtensionCall> ExtensionCall { get; set; }
        public virtual DbSet<Mailimza> Mailimza { get; set; }
        public virtual DbSet<MailSablon> MailSablon { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Numbers> Numbers { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<SablonList> SablonList { get; set; }
        public virtual DbSet<SendSms> SendSms { get; set; }
        public virtual DbSet<SentMessages> SentMessages { get; set; }
        public virtual DbSet<SmsRequest> SmsRequest { get; set; }
        public virtual DbSet<StatusHistories> StatusHistories { get; set; }
        public virtual DbSet<StatusNames> StatusNames { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<TaskDependencies> TaskDependencies { get; set; }
        public virtual DbSet<AgentCallLogs> AgentCallLogs { get; set; }
        public virtual DbSet<AgentGroupHierarchies> AgentGroupHierarchies { get; set; }
        public virtual DbSet<AgentGroupHistories> AgentGroupHistories { get; set; }
        public virtual DbSet<AgentGroups> AgentGroups { get; set; }
        public virtual DbSet<AgentProcesses> AgentProcesses { get; set; }
        public virtual DbSet<AgentStatusLogs> AgentStatusLogs { get; set; }
        public virtual DbSet<CallResults> CallResults { get; set; }
        public virtual DbSet<CallStatus> CallStatus { get; set; }
        public virtual DbSet<CallStatusLogs> CallStatusLogs { get; set; }
        public virtual DbSet<CallTypes> CallTypes { get; set; }
        public virtual DbSet<cars> cars { get; set; }
        public virtual DbSet<CheckSendCalls> CheckSendCalls { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<ContactLogs> ContactLogs { get; set; }
        public virtual DbSet<ContactNotes> ContactNotes { get; set; }
        public virtual DbSet<ContactPhotos> ContactPhotos { get; set; }
        public virtual DbSet<contactsTask> contactsTask { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DeletedRecords> DeletedRecords { get; set; }
        public virtual DbSet<Enums> Enums { get; set; }
        public virtual DbSet<EnumValues> EnumValues { get; set; }
        public virtual DbSet<Firmalar> Firmalar { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<Ilceler> Ilceler { get; set; }
        public virtual DbSet<InfoNumbers> InfoNumbers { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<NumberInfos> NumberInfos { get; set; }
        public virtual DbSet<Numbers1> Numbers1 { get; set; }
        public virtual DbSet<OutoDilerJops> OutoDilerJops { get; set; }
        public virtual DbSet<Personels> Personels { get; set; }
        public virtual DbSet<RegionHierarchies> RegionHierarchies { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<ResultTypes> ResultTypes { get; set; }
        public virtual DbSet<RoomTypes> RoomTypes { get; set; }
        public virtual DbSet<StatusType> StatusType { get; set; }
        public virtual DbSet<SubscriberCallHistories> SubscriberCallHistories { get; set; }
        public virtual DbSet<SubscriberComplaints> SubscriberComplaints { get; set; }
        public virtual DbSet<SubscriberLayoverHistories> SubscriberLayoverHistories { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<t1> t1 { get; set; }
        public virtual DbSet<TapiCallStatus> TapiCallStatus { get; set; }
        public virtual DbSet<TapiIncomingCalls> TapiIncomingCalls { get; set; }
        public virtual DbSet<Tarifler> Tarifler { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<XivrPortExtensions> XivrPortExtensions { get; set; }
        public virtual DbSet<WhatIsLocked> WhatIsLocked { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A_MAIL>()
                .Property(e => e.POPMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<A_MAIL>()
                .Property(e => e.POPPASS)
                .IsUnicode(false);

            modelBuilder.Entity<A_MAIL>()
                .Property(e => e.POPSMTP)
                .IsUnicode(false);

            modelBuilder.Entity<A_MAIL>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);

            modelBuilder.Entity<A_MAIL>()
                .Property(e => e.ALTMESAJ)
                .IsUnicode(false);

            modelBuilder.Entity<A_MODUL>()
                .Property(e => e.MODULADI)
                .IsUnicode(false);

            modelBuilder.Entity<A_MUSTERIMODUL>()
                .Property(e => e.MUSTERINO)
                .IsUnicode(false);

            modelBuilder.Entity<A_MUSTERIMODUL>()
                .Property(e => e.MUSTERIADI)
                .IsUnicode(false);

            modelBuilder.Entity<A_MUSTERIMODUL>()
                .Property(e => e.MODULID)
                .IsUnicode(false);

            modelBuilder.Entity<A_MUSTERIMODUL>()
                .Property(e => e.SUBMODULID)
                .IsUnicode(false);

            modelBuilder.Entity<A_YETKI>()
                .Property(e => e.YETKIID)
                .IsUnicode(false);

            modelBuilder.Entity<A_YETKI>()
                .Property(e => e.YETKIADI)
                .IsUnicode(false);

            modelBuilder.Entity<A_YETKIDETAY>()
                .Property(e => e.YETKIID)
                .IsUnicode(false);

            modelBuilder.Entity<AgentSetting>()
                .Property(e => e.AgentCode)
                .IsUnicode(false);

            modelBuilder.Entity<AgentSetting>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<CallHistories>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<CallHistories>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<CallHistories>()
                .Property(e => e.Agent)
                .IsUnicode(false);

            modelBuilder.Entity<ContactDesc>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ContactMails>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<ContactMails>()
                .Property(e => e.maildesc)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.SurName)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.companyaddress)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.tax)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.taxno)
                .IsFixedLength();

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Yukleme)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_Log>()
                .Property(e => e.LogIslemAciklama)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_Log>()
                .Property(e => e.SmsSendId)
                .IsUnicode(false);

            modelBuilder.Entity<ExtensionCall>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<ExtensionCall>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<Mailimza>()
                .Property(e => e.IMZA)
                .IsUnicode(false);

            modelBuilder.Entity<MailSablon>()
                .Property(e => e.SABLONADI)
                .IsUnicode(false);

            modelBuilder.Entity<MailSablon>()
                .Property(e => e.SABLON)
                .IsUnicode(false);

            modelBuilder.Entity<MailSablon>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<Notes>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<Notes>()
                .Property(e => e.urun)
                .IsUnicode(false);

            modelBuilder.Entity<Numbers>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Numbers>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Numbers>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<Numbers>()
                .Property(e => e.maildesc)
                .IsUnicode(false);

            modelBuilder.Entity<SablonList>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<SablonList>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SablonList>()
                .Property(e => e.SaveUser)
                .IsUnicode(false);

            modelBuilder.Entity<SentMessages>()
                .Property(e => e.Numara)
                .IsUnicode(false);

            modelBuilder.Entity<SentMessages>()
                .Property(e => e.Mesaj)
                .IsUnicode(false);

            modelBuilder.Entity<SentMessages>()
                .Property(e => e.GeriDonenID)
                .IsUnicode(false);

            modelBuilder.Entity<SentMessages>()
                .Property(e => e.TopluMesaj)
                .IsUnicode(false);

            modelBuilder.Entity<SmsRequest>()
                .Property(e => e.Agent)
                .IsUnicode(false);

            modelBuilder.Entity<SmsRequest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SmsRequest>()
                .Property(e => e.SurName)
                .IsUnicode(false);

            modelBuilder.Entity<SmsRequest>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<SmsRequest>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<SmsRequest>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.EditBy)
                .IsUnicode(false);

            modelBuilder.Entity<AgentCallLogs>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<AgentCallLogs>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<AgentGroups>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AgentGroups>()
                .Property(e => e.Agents)
                .IsUnicode(false);

            modelBuilder.Entity<AgentGroups>()
                .Property(e => e.Calls)
                .IsUnicode(false);

            modelBuilder.Entity<AgentProcesses>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<AgentProcesses>()
                .Property(e => e.Groups)
                .IsUnicode(false);

            modelBuilder.Entity<AgentProcesses>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AgentStatusLogs>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.Called)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.SoundFile)
                .IsUnicode(false);

            modelBuilder.Entity<CallResults>()
                .Property(e => e.AgentName)
                .IsUnicode(false);

            modelBuilder.Entity<CallStatusLogs>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<CallStatusLogs>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<CallTypes>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CallTypes>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CheckSendCalls>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<CheckSendCalls>()
                .Property(e => e.Called)
                .IsUnicode(false);

            modelBuilder.Entity<Cities>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Cities>()
                .Property(e => e.CityCode)
                .IsUnicode(false);

            modelBuilder.Entity<Cities>()
                .Property(e => e.CityPhoneCode)
                .IsUnicode(false);

            modelBuilder.Entity<ContactLogs>()
                .Property(e => e.Log)
                .IsUnicode(false);

            modelBuilder.Entity<ContactNotes>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPhotos>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPhotos>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedRecords>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Enums>()
                .Property(e => e.EnumName)
                .IsUnicode(false);

            modelBuilder.Entity<Enums>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<EnumValues>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EnumValues>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Hotels>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hotels>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Ilceler>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Ilceler>()
                .Property(e => e.Long)
                .IsUnicode(false);

            modelBuilder.Entity<Ilceler>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<InfoNumbers>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<InfoNumbers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<InfoNumbers>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<InfoNumbers>()
                .Property(e => e.SoundFile)
                .IsUnicode(false);

            modelBuilder.Entity<NumberInfos>()
                .Property(e => e.InfoName)
                .IsUnicode(false);

            modelBuilder.Entity<Numbers1>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Numbers1>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<OutoDilerJops>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Personels>()
                .Property(e => e.Personel)
                .IsUnicode(false);

            modelBuilder.Entity<Personels>()
                .Property(e => e.Prm1)
                .IsUnicode(false);

            modelBuilder.Entity<Personels>()
                .Property(e => e.Prm2)
                .IsUnicode(false);

            modelBuilder.Entity<Personels>()
                .Property(e => e.Prm3)
                .IsUnicode(false);

            modelBuilder.Entity<Regions>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Regions>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ResultTypes>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ResultTypes>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RoomTypes>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RoomTypes>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberCallHistories>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberCallHistories>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberCallHistories>()
                .Property(e => e.Agent)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberCallHistories>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberCallHistories>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberCallHistories>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.Agent)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.DepResult)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.ReCallAgent)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberComplaints>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.PensionType)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.SaleType)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.Office)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.Seller)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.DiscountDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.Invoice)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<SubscriberLayoverHistories>()
                .Property(e => e.ChildBirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<Subscribers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subscribers>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Subscribers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Subscribers>()
                .Property(e => e.District)
                .IsUnicode(false);

            modelBuilder.Entity<Subscribers>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<t1>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TapiCallStatus>()
                .Property(e => e.Line)
                .IsUnicode(false);

            modelBuilder.Entity<TapiCallStatus>()
                .Property(e => e.Call)
                .IsUnicode(false);

            modelBuilder.Entity<TapiCallStatus>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<TapiCallStatus>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<TapiCallStatus>()
                .Property(e => e.Called)
                .IsUnicode(false);

            modelBuilder.Entity<TapiCallStatus>()
                .Property(e => e.CallerFull)
                .IsUnicode(false);

            modelBuilder.Entity<TapiIncomingCalls>()
                .Property(e => e.CallerFull)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.UniqueCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.BasAdres)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.Basjb)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.Baskb)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.BitAdres)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.Bitjb)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.Bitkb)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.SureText)
                .IsUnicode(false);

            modelBuilder.Entity<Tarifler>()
                .Property(e => e.MesafeText)
                .IsUnicode(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Task)
                .IsUnicode(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.TaskInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Prm1)
                .IsUnicode(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Prm2)
                .IsUnicode(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Prm3)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.NameSurname)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<XivrPortExtensions>()
                .Property(e => e.Extension)
                .IsUnicode(false);
        }
    }
}
