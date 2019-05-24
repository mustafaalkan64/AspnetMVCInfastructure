namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentSetting")]
    public partial class AgentSetting
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string AgentCode { get; set; }

        [StringLength(10)]
        public string Prefix { get; set; }
    }
}
