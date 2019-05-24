namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactGroup")]
    public partial class ContactGroup
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Group { get; set; }

        public int? GroupId { get; set; }

        public bool? IsReal { get; set; }
    }
}
