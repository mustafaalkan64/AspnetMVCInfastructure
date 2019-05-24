namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tasks
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonelId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContactId { get; set; }

        [StringLength(1000)]
        public string Task { get; set; }

        [StringLength(2000)]
        public string TaskInfo { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime StartTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FinishTime { get; set; }

        [StringLength(1000)]
        public string Prm1 { get; set; }

        [StringLength(1000)]
        public string Prm2 { get; set; }

        [StringLength(1000)]
        public string Prm3 { get; set; }

        public int? CarId { get; set; }

        [StringLength(50)]
        public string AgentId { get; set; }

        [StringLength(150)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string Note1 { get; set; }

        [StringLength(50)]
        public string Note2 { get; set; }

        [StringLength(150)]
        public string Adress { get; set; }

        [StringLength(150)]
        public string Adress2 { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }
    }
}
