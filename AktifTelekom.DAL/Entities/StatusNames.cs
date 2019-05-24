namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StatusNames
    {
        public int Id { get; set; }

        public int? StatusId { get; set; }

        [StringLength(250)]
        public string StatusName { get; set; }

        public bool? Hesap { get; set; }
    }
}
