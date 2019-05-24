namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberCallHistories
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubscriberId { get; set; }

        [StringLength(255)]
        public string Caller { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CallDate { get; set; }

        [StringLength(255)]
        public string Extension { get; set; }

        [StringLength(255)]
        public string Agent { get; set; }

        public int? HotelId { get; set; }

        [StringLength(1000)]
        public string Subject { get; set; }

        public int? RoomTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime InputDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime OutputDate { get; set; }

        public int? RoomNo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Adult { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Child { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FreeChild { get; set; }

        [StringLength(50)]
        public string VoucherNo { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsComplaint { get; set; }

        public int? ResultId { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessType { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime EditDate { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }
    }
}
