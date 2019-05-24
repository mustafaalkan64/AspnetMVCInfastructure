namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_YETKIDETAY
    {
        public int ID { get; set; }

        public int? MODULID { get; set; }

        public bool? OKU { get; set; }

        public bool? YAZ { get; set; }

        public bool? SIL { get; set; }

        public bool? DINLE { get; set; }

        public bool? EKSTRA { get; set; }

        public bool? EKSTRA2 { get; set; }

        [StringLength(50)]
        public string YETKIID { get; set; }

        [StringLength(250)]
        public string AGENTS { get; set; }
    }
}
