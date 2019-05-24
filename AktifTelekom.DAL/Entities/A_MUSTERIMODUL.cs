namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_MUSTERIMODUL
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MUSTERINO { get; set; }

        [StringLength(50)]
        public string MUSTERIADI { get; set; }

        public string MODULID { get; set; }

        public string SUBMODULID { get; set; }
    }
}
