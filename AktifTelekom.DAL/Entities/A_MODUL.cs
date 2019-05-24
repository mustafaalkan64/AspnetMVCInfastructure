namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_MODUL
    {
        public int ID { get; set; }

        public int? MODULID { get; set; }

        [StringLength(100)]
        public string MODULADI { get; set; }

        public int? TIP { get; set; }

        public bool? LISTE { get; set; }
    }
}
