namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notes
    {
        public int Id { get; set; }

        public int Exten_Id { get; set; }

        [Column(TypeName = "text")]
        public string note { get; set; }

        [Column(TypeName = "text")]
        public string urun { get; set; }

        public int? ContactId { get; set; }
    }
}
