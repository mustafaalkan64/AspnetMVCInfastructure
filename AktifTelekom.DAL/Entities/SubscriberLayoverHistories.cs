namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberLayoverHistories
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubscriberId { get; set; }

        public int? HotelId { get; set; }

        public int? RoomTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime InputDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OutputDate { get; set; }

        [StringLength(50)]
        public string VoucherNo { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Price { get; set; }

        public int? ResultId { get; set; }

        public int? FidelioRez { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomNo { get; set; }

        public int? ExtraBed { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C1 { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C2 { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Free { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PAX { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessType { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime EditDate { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(255)]
        public string PensionType { get; set; }

        [StringLength(255)]
        public string Category { get; set; }

        [StringLength(255)]
        public string SaleType { get; set; }

        [StringLength(255)]
        public string Office { get; set; }

        [StringLength(255)]
        public string Seller { get; set; }

        [StringLength(500)]
        public string DiscountDescription { get; set; }

        [StringLength(255)]
        public string Invoice { get; set; }

        [StringLength(255)]
        public string AccountCode { get; set; }

        public DateTime? SaleDate { get; set; }

        [StringLength(500)]
        public string ChildBirthDate { get; set; }
    }
}
