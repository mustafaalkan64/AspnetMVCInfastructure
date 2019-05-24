namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MailSablon")]
    public partial class MailSablon
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SABLONADI { get; set; }

        public string SABLON { get; set; }

        [StringLength(50)]
        public string UPDATEUSER { get; set; }
    }
}
