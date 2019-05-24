namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WhatIsLocked")]
    public partial class WhatIsLocked
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SessionID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string LockedObjectName { get; set; }

        public int? Duration { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Transaction_begin_time { get; set; }

        public int? Locks { get; set; }
    }
}
