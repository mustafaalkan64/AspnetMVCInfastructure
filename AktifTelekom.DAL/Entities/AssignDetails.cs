namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AssignDetails
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        [StringLength(250)]
        public string Assign { get; set; }

        [StringLength(250)]
        public string AssignTo { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(250)]
        public string Before { get; set; }
    }
}
