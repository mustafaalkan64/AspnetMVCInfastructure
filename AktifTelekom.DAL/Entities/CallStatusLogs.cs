namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CallStatusLogs
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Caller { get; set; }

        [StringLength(255)]
        public string Callee { get; set; }

        public int? PortNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CallStartTime { get; set; }

        public int? Dtmf { get; set; }

        public int? AgentGroupId { get; set; }

        public int? AgentId { get; set; }

        public DateTime? ReceptionTime { get; set; }

        public DateTime? CallEndTime { get; set; }

        public int? Extension { get; set; }
    }
}
