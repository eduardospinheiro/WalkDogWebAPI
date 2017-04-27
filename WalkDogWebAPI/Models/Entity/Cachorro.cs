namespace WalkDogWebAPI.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cachorro")]
    public partial class Cachorro
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Required]
        [StringLength(15)]
        public string porte { get; set; }

        [Required]
        [StringLength(50)]
        public string agressividade { get; set; }

        public int idDono { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
