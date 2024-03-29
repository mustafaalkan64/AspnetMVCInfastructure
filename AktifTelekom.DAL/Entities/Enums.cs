namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Enums
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnumId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string EnumName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
