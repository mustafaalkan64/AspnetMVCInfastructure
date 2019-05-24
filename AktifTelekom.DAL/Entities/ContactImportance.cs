namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactImportance")]
    public partial class ContactImportance
    {
        public int Id { get; set; }

        public int? ContactImportanceId { get; set; }

        [StringLength(50)]
        public string ContactImportanceName { get; set; }
    }
}
