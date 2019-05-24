namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Survey")]
    public partial class Survey
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        public int? Ans1 { get; set; }

        public int? Ans2 { get; set; }

        public int? Ans3 { get; set; }

        public int? Ans4 { get; set; }

        public int? Ans5 { get; set; }

        public int? Ans6 { get; set; }

        public int? Ans7 { get; set; }

        public int? Ans8 { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? EditDate { get; set; }

        [StringLength(250)]
        public string EditBy { get; set; }
    }
}
