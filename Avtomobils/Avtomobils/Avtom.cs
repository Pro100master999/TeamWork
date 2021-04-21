namespace Avtomobils
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avtom")]
    public partial class Avtom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nomer { get; set; }

        [Required]
        [StringLength(20)]
        public string Owner { get; set; }

        [Required]
        [StringLength(20)]
        public string Marka { get; set; }

        public int Age { get; set; }
    }
}
