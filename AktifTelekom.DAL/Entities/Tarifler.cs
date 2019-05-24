namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tarifler")]
    public partial class Tarifler
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string UniqueCode { get; set; }

        [StringLength(1000)]
        public string BasAdres { get; set; }

        [StringLength(55)]
        public string Basjb { get; set; }

        [StringLength(55)]
        public string Baskb { get; set; }

        [StringLength(1000)]
        public string BitAdres { get; set; }

        [StringLength(55)]
        public string Bitjb { get; set; }

        [StringLength(55)]
        public string Bitkb { get; set; }

        [StringLength(100)]
        public string SureText { get; set; }

        public int? Sure { get; set; }

        [StringLength(100)]
        public string MesafeText { get; set; }

        public int? Mesafe { get; set; }
    }
}
