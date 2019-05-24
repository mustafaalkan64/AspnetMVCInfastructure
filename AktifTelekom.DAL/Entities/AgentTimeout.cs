namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentTimeout")]
    public partial class AgentTimeout
    {
        public int Id { get; set; }

        public int? TimeoutId { get; set; }

        [StringLength(50)]
        public string TimeoutName { get; set; }
    }
}
