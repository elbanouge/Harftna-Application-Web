using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("PRODUIT")]
    public partial class Produit
    {
        public Produit()
        {
            Avis = new HashSet<Avi>();
            Commanders = new HashSet<Commander>();
            Media = new HashSet<Medium>();
            Paniers = new HashSet<Panier>();
            Singlers = new HashSet<Singler>();
        }

        [Key]
        [Column("IDPRO")]
        public int Idpro { get; set; }
        [Column("IDGPRO")]
        public int? Idgpro { get; set; }
        [Column("NOMP")]
        [StringLength(25)]
        public string Nomp { get; set; }
        [Column("DESCRIPTIONPRO", TypeName = "text")]
        public string Descriptionpro { get; set; }
        [Column("PRIXPRO", TypeName = "money")]
        public decimal? Prixpro { get; set; }
        [Column("QTESTOCKPRO")]
        public int? Qtestockpro { get; set; }
        [Column("VEDIOPRO", TypeName = "image")]
        public byte[] Vediopro { get; set; }
        [Column("POIDPRO")]
        public double? Poidpro { get; set; }
        [Column("ORIGINPRO")]
        [StringLength(20)]
        public string Originpro { get; set; }
        [Column("PRLVERIFIERPRO")]
        public bool? Prlverifierpro { get; set; }
        [Column("MISEAJOURPRO", TypeName = "datetime")]
        public DateTime? Miseajourpro { get; set; }
        [Column("REMISESPRO")]
        public int? Remisespro { get; set; }
        [Column("IDFRSPRO")]
        public int? Idfrspro { get; set; }

        [ForeignKey(nameof(Idfrspro))]
        [InverseProperty(nameof(Fournisseur.Produits))]
        public virtual Fournisseur IdfrsproNavigation { get; set; }
        [ForeignKey(nameof(Idgpro))]
        [InverseProperty(nameof(Genre.Produits))]
        public virtual Genre IdgproNavigation { get; set; }
        [InverseProperty(nameof(Avi.IdpaviNavigation))]
        public virtual ICollection<Avi> Avis { get; set; }
        [InverseProperty(nameof(Commander.IdpcomNavigation))]
        public virtual ICollection<Commander> Commanders { get; set; }
        [InverseProperty(nameof(Medium.IdpmedNavigation))]
        public virtual ICollection<Medium> Media { get; set; }
        [InverseProperty(nameof(Panier.IdpanNavigation))]
        public virtual ICollection<Panier> Paniers { get; set; }
        [InverseProperty(nameof(Singler.IdpsingNavigation))]
        public virtual ICollection<Singler> Singlers { get; set; }
    }
}
