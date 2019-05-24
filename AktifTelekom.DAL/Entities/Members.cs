namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Members
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Sube { get; set; }

        [StringLength(50)]
        public string SubeMdr { get; set; }

        [StringLength(50)]
        public string Kod { get; set; }

        [StringLength(50)]
        public string Dealer { get; set; }

        [StringLength(50)]
        public string Unvan { get; set; }

        [StringLength(20)]
        public string SeansOdasi { get; set; }

        [StringLength(20)]
        public string SeansOdasi2 { get; set; }

        [StringLength(20)]
        public string SubeTel { get; set; }

        [StringLength(20)]
        public string EvTel { get; set; }

        [StringLength(20)]
        public string CepTel { get; set; }
    }
}
