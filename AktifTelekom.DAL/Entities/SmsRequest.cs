namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsRequest")]
    public partial class SmsRequest
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Agent { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string SurName { get; set; }

        public string Message { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? SendDate { get; set; }

        public bool? IsSend { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
