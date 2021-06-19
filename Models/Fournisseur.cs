using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("FOURNISSEUR")]
    public partial class Fournisseur
    {
        public Fournisseur()
        {
            Produits = new HashSet<Produit>();
        }

        [Key]
        [Column("IDFOUR")]
        public int Idfour { get; set; }
        [Column("IDUTLFOUR")]
        public int? Idutlfour { get; set; }
        [Column("FAXFOUR")]
        [StringLength(25)]
        public string Faxfour { get; set; }
        [Column("DOMAINEFOUR")]
        [StringLength(25)]
        public string Domainefour { get; set; }

        [ForeignKey(nameof(Idutlfour))]
        [InverseProperty(nameof(Utilisateur.Fournisseurs))]
        public virtual Utilisateur IdutlfourNavigation { get; set; }
        [InverseProperty(nameof(Produit.IdfrsproNavigation))]
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
