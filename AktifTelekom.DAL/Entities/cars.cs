namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cars
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(250)]
        public string carno { get; set; }

        [StringLength(250)]
        public string driverno { get; set; }

        [StringLength(250)]
        public string location { get; set; }

        [StringLength(250)]
        public string gsmno { get; set; }

        [StringLength(250)]
        public string par1 { get; set; }

        [StringLength(250)]
        public string par2 { get; set; }

        [StringLength(250)]
        public string par3 { get; set; }
    }
}
