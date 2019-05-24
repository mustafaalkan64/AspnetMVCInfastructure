namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SentMessages
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Numara { get; set; }

        [StringLength(50)]
        public string Mesaj { get; set; }

        public DateTime? Tarih { get; set; }

        [StringLength(50)]
        public string GeriDonenID { get; set; }

        [StringLength(50)]
        public string TopluMesaj { get; set; }
    }
}
