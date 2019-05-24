namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Numbers1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ContactId { get; set; }

        public int? SubscriberId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Number { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Type { get; set; }

        public int? ProcessType { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? EditDate { get; set; }

        public int? Code { get; set; }
    }
}
