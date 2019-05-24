namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t1
    {
        [Key]
        [Column(Order = 0)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int object_id { get; set; }

        public int? principal_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int schema_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parent_object_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string type { get; set; }

        [StringLength(60)]
        public string type_desc { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime create_date { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime modify_date { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool is_ms_shipped { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool is_published { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool is_schema_published { get; set; }
    }
}
