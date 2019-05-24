namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtensionCall")]
    public partial class ExtensionCall
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Caller { get; set; }

        [StringLength(50)]
        public string Callee { get; set; }

        public int? Called { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
