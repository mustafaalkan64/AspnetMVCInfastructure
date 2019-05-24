namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AgentGroupHistories
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? AgentId { get; set; }

        public int? GroupId { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime InDate { get; set; }

        public DateTime? OutDate { get; set; }
    }
}
