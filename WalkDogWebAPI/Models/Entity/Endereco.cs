namespace WalkDogWebAPI.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Endereco")]
    public partial class Endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Endereco()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string tipoLogradouro { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeLogradouro { get; set; }

        public int numero { get; set; }

        public int? apartamento { get; set; }

        [Required]
        [StringLength(30)]
        public string bairro { get; set; }

        [Required]
        [StringLength(30)]
        public string cidade { get; set; }

        [Required]
        [MaxLength(30)]
        public byte[] estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
