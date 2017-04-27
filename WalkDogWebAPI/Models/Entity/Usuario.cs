namespace WalkDogWebAPI.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Cachorro = new HashSet<Cachorro>();
            Passeio = new HashSet<Passeio>();
            Passeio1 = new HashSet<Passeio>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string senha { get; set; }

        [Required]
        [StringLength(70)]
        public string nomeUsuario { get; set; }

        public int idEndereco { get; set; }

        [Required]
        [StringLength(11)]
        public string telefone { get; set; }

        [Required]
        [StringLength(100)]
        public string facebook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cachorro> Cachorro { get; set; }

        public virtual Endereco Endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passeio> Passeio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passeio> Passeio1 { get; set; }
    }
}
