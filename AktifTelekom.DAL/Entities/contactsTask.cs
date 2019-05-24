namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contactsTask")]
    public partial class contactsTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContactId { get; set; }

        [StringLength(50)]
        public string contactname { get; set; }

        [StringLength(50)]
        public string contactofficetel { get; set; }

        [StringLength(50)]
        public string contactmail { get; set; }

        [StringLength(50)]
        public string contactlocation { get; set; }

        [StringLength(50)]
        public string contactmobile { get; set; }

        [StringLength(50)]
        public string companyname { get; set; }

        [StringLength(50)]
        public string companyadress { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        [StringLength(50)]
        public string par1 { get; set; }

        [StringLength(50)]
        public string par2 { get; set; }
    }
}
