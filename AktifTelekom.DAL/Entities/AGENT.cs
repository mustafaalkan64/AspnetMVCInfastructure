namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AGENT")]
    public partial class AGENT
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string AGENTKODU { get; set; }

        [StringLength(50)]
        public string AGENTADI { get; set; }
    }
}
