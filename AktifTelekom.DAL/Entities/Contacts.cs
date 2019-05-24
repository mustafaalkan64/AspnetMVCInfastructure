namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contacts
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string SurName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string MobilePhone { get; set; }

        [StringLength(15)]
        public string HomePhone { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int? Status { get; set; }

        [StringLength(255)]
        public string company { get; set; }

        public string companyaddress { get; set; }

        [StringLength(255)]
        public string tax { get; set; }

        [StringLength(30)]
        public string taxno { get; set; }

        public int? GroupId { get; set; }

        public int? GroupId2 { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? EditDate { get; set; }

        public int? Durum { get; set; }

        [StringLength(250)]
        public string DurumName { get; set; }

        [StringLength(50)]
        public string Agent { get; set; }

        public short? IsNew { get; set; }

        public DateTime? RandevuTarihi { get; set; }

        public string Aciklama { get; set; }

        public bool? ReturnToReal { get; set; }

        public bool? Acildimi { get; set; }

        public int? AramaDurumId { get; set; }

        [StringLength(100)]
        public string EditBy { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        [StringLength(50)]
        public string Portfoy { get; set; }

        public int? ContactImportance { get; set; }

        public int? StatusType { get; set; }

        public bool? StatusWarning { get; set; }

        public bool? NoSms { get; set; }

        public DateTime? AramaTarih { get; set; }

        public DateTime? AtamaTarih { get; set; }

        public int? YuklemeAgent { get; set; }

        [StringLength(10)]
        public string Yukleme { get; set; }
    }
}
