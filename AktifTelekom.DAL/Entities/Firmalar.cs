namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firmalar")]
    public partial class Firmalar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Firma { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        public int? LocationId { get; set; }

        public int? Field1 { get; set; }
    }
}
