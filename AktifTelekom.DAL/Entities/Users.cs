namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(255)]
        public string NameSurname { get; set; }

        public int? PriorityLevel { get; set; }

        public int? Extension { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecurityLevel { get; set; }

        public int? Status { get; set; }

        [StringLength(250)]
        public string EMail { get; set; }

        public int? YetkiId { get; set; }

        public int? GrupId { get; set; }

        public bool? ZamanKisit { get; set; }
    }
}
