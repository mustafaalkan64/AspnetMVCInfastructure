namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactLogs
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? EditDate { get; set; }

        [Column(TypeName = "text")]
        public string Log { get; set; }

        public int? AgentId { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsSchedule { get; set; }

        public DateTime? ScheduleDate { get; set; }

        public int? Status { get; set; }

        public int? ContactId { get; set; }
    }
}
