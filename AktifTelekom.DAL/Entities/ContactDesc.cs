namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactDesc")]
    public partial class ContactDesc
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(50)]
        public string Agent { get; set; }

        public DateTime? Date { get; set; }
    }
}
