namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personels
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonelId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Personel { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [StringLength(1000)]
        public string Prm1 { get; set; }

        [StringLength(1000)]
        public string Prm2 { get; set; }

        [StringLength(1000)]
        public string Prm3 { get; set; }
    }
}
