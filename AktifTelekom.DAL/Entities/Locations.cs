namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Locations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(250)]
        public string City { get; set; }

        [StringLength(250)]
        public string Latitude { get; set; }

        [StringLength(250)]
        public string Longitude { get; set; }

        public DateTime? CreaDate { get; set; }

        [StringLength(250)]
        public string Desc { get; set; }

        [StringLength(250)]
        public string prm1 { get; set; }

        [StringLength(250)]
        public string prm2 { get; set; }

        [StringLength(250)]
        public string prm3 { get; set; }
    }
}
