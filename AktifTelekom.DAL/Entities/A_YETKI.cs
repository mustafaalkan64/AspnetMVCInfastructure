namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_YETKI
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string YETKIID { get; set; }

        [StringLength(50)]
        public string YETKIADI { get; set; }
    }
}
