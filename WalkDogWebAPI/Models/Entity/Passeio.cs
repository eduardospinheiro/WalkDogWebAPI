namespace WalkDogWebAPI.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Passeio")]
    public partial class Passeio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passeio()
        {
            Avaliacao = new HashSet<Avaliacao>();
        }

        public int id { get; set; }

        public int idUsuarioPasseador { get; set; }

        public int idCachorroEmprestado { get; set; }

        [Required]
        [StringLength(50)]
        public string ultimoLocal { get; set; }

        public bool confirmacaoPasseioDono { get; set; }

        public bool? confirmacaoDevolucaoPasseador { get; set; }

        public bool? confirmacaoDevolucaoDono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Usuario Usuario1 { get; set; }
    }
}
