namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resources
    {
        public int Id { get; set; }

        public int? IdSort { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }

        public int? Color { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public string CustomField1 { get; set; }
    }
}
