namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CallResults
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumberInfoId { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(50)]
        public string Called { get; set; }

        [StringLength(50)]
        public string Caller { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TSType { get; set; }

        public int? TSTypeCount { get; set; }

        public int? GroupId { get; set; }

        [StringLength(250)]
        public string Result { get; set; }

        [StringLength(8000)]
        public string SoundFile { get; set; }

        public int? InfoNumberId { get; set; }

        public int? ChannelIndex { get; set; }

        public bool? IsGroupSend { get; set; }

        public bool? IsComplate { get; set; }

        public int? Index { get; set; }

        [StringLength(250)]
        public string AgentName { get; set; }

        public int? AgentExtension { get; set; }

        public int? ReCallCount { get; set; }
    }
}
