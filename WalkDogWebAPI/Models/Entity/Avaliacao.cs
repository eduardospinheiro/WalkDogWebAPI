namespace WalkDogWebAPI.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avaliacao")]
    public partial class Avaliacao
    {
        public int id { get; set; }

        public int idPasseio { get; set; }

        public int notaPasseador { get; set; }

        public int notaDono { get; set; }

        public virtual Passeio Passeio { get; set; }
    }
}
