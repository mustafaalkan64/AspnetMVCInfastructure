namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_MAIL
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string POPMAIL { get; set; }

        [StringLength(50)]
        public string POPPASS { get; set; }

        [StringLength(50)]
        public string POPSMTP { get; set; }

        public int? POPPORT { get; set; }

        public bool? POPSSL { get; set; }

        public string BASLIK { get; set; }

        public string ALTMESAJ { get; set; }

        public int? AGENT { get; set; }
    }
}
