namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointments
    {
        [Key]
        public int UniqueId { get; set; }

        public int? Type { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public bool? AllDay { get; set; }

        public string Subject { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public int? Status { get; set; }

        public int? Label { get; set; }

        public int? ResourceId { get; set; }

        public string ResourceIds { get; set; }

        public string ReminderInfo { get; set; }

        public string RecurrenceInfo { get; set; }

        public int? PercentComplete { get; set; }

        public string CustomField1 { get; set; }
    }
}
