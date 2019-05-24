namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactRandevu")]
    public partial class ContactRandevu
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        public DateTime? Date { get; set; }

        public string aciklama { get; set; }

        public bool? Acildimi { get; set; }

        public int? Agent { get; set; }
    }
}
