namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberComplaints
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubscriberId { get; set; }

        [StringLength(1000)]
        public string Subject { get; set; }

        [StringLength(50)]
        public string Agent { get; set; }

        [StringLength(50)]
        public string Extension { get; set; }

        public int? HotelId { get; set; }

        [StringLength(255)]
        public string Department { get; set; }

        public DateTime? DepTransDate { get; set; }

        public DateTime? DepResultDate { get; set; }

        [StringLength(4000)]
        public string DepResult { get; set; }

        [StringLength(50)]
        public string ReCallAgent { get; set; }

        public DateTime? ReCallDate { get; set; }

        [StringLength(4000)]
        public string Result { get; set; }

        public int? RoomNo { get; set; }

        public bool? Status { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessType { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime EditDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }
    }
}
