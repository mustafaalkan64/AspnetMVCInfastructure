namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OutoDilerJops
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ReTryCount { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        public int? GroupId { get; set; }

        public int? Status { get; set; }

        public int? CallStatusLogId { get; set; }

        public DateTime? StartDate { get; set; }
    }
}
