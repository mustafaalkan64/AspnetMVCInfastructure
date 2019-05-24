namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SablonList")]
    public partial class SablonList
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(150)]
        public string SaveUser { get; set; }

        public DateTime CreDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
