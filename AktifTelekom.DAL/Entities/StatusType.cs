namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusType")]
    public partial class StatusType
    {
        public int ID { get; set; }

        public int? StatusId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}
