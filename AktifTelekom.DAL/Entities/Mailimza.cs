namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mailimza")]
    public partial class Mailimza
    {
        public int ID { get; set; }

        public int? AGENTID { get; set; }

        public string IMZA { get; set; }
    }
}
