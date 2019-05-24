namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AGENTGRUP")]
    public partial class AGENTGRUP
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string AGENTGRUPKODU { get; set; }

        [StringLength(150)]
        public string AGENTGRUPADI { get; set; }

        [StringLength(1500)]
        public string AGENTS { get; set; }

        public bool? GIZLIAGENT { get; set; }
    }
}
