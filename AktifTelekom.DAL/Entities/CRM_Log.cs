namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRM_Log
    {
        [Key]
        public int LogId { get; set; }

        [StringLength(50)]
        public string LogModul { get; set; }

        [StringLength(50)]
        public string LogIslem { get; set; }

        public string LogIslemAciklama { get; set; }

        public DateTime? LogKayitTarih { get; set; }

        [StringLength(50)]
        public string KullaniciNo { get; set; }

        [StringLength(20)]
        public string IslemNo { get; set; }

        public int? ContactId { get; set; }

        [StringLength(50)]
        public string SmsSendId { get; set; }

        public int? Agent { get; set; }
    }
}
