namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subscribers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsAgency { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [StringLength(100)]
        public string District { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LayoverCount { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Status { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessType { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime EditDate { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }
    }
}
