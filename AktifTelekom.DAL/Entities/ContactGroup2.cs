namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactGroup2
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Group { get; set; }

        public int? GroupId { get; set; }
    }
}
