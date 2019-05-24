namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactMails
    {
        public int Id { get; set; }

        public string mail { get; set; }

        public bool? mailizin { get; set; }

        [Column(TypeName = "text")]
        public string maildesc { get; set; }

        public int? ContactId { get; set; }
    }
}
