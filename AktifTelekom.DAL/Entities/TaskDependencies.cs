namespace AktifTelekom.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TaskDependencies
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int? DependentId { get; set; }

        public int Type { get; set; }
    }
}
