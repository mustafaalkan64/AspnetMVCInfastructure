namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InfoNumbers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumberInfoId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int? TSType { get; set; }

        public DateTime? TSStartDate { get; set; }

        public int? TSTypeCount { get; set; }

        public int? GroupId { get; set; }

        public bool? IsCall { get; set; }

        [StringLength(250)]
        public string Result { get; set; }

        [StringLength(8000)]
        public string SoundFile { get; set; }

        public bool? IsGroupSend { get; set; }

        public int? Index { get; set; }

        public int? Status { get; set; }

        public int? ReCallCount { get; set; }

        public int? CallResultId { get; set; }

        public int? ChannelIndex { get; set; }
    }
}
