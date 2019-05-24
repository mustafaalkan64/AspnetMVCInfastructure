namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TapiCallStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Line { get; set; }

        [StringLength(255)]
        public string Call { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string Caller { get; set; }

        [StringLength(255)]
        public string Called { get; set; }

        public int? AgentId { get; set; }

        public int? CannelIndex { get; set; }

        public int? CallStatusLogId { get; set; }

        public int? AgentCallLogId { get; set; }

        public int? Extension { get; set; }

        [StringLength(255)]
        public string CallerFull { get; set; }
    }
}
