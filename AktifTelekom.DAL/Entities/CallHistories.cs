namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CallHistories
    {
        public int Id { get; set; }

        public int ContactId { get; set; }

        [StringLength(255)]
        public string Caller { get; set; }

        public DateTime? CallDate { get; set; }

        [StringLength(255)]
        public string Extension { get; set; }

        [StringLength(255)]
        public string Agent { get; set; }

        public int? RegionId { get; set; }

        public int? CallTypeId { get; set; }

        [StringLength(10)]
        public string Durum { get; set; }

        [StringLength(250)]
        public string DurumName { get; set; }

        [StringLength(255)]
        public string Sube { get; set; }

        public DateTime? RandevuTarihi { get; set; }

        public string Aciklama { get; set; }
    }
}
