namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StatusHistories
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        public int? StatusId { get; set; }

        public DateTime? Date { get; set; }
    }
}
