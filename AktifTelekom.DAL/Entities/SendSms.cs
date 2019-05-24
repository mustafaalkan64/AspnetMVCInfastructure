namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SendSms
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string GsmNo { get; set; }

        [StringLength(160)]
        public string SmsMessage { get; set; }

        [StringLength(150)]
        public string ReturnValue { get; set; }

        public bool? IsSend { get; set; }

        public DateTime? SendDate { get; set; }

        public DateTime? WriteDate { get; set; }

        public int? Status { get; set; }
    }
}
