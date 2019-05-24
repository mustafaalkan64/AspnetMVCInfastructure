namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CallStatus
    {
        public int Id { get; set; }

        public int? CallStatusId { get; set; }

        [StringLength(150)]
        public string AramaDurumu { get; set; }
    }
}
