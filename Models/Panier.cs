using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("PANIER")]
    public partial class Panier
    {
        [Key]
        [Column("IDUTL2PAN")]
        public int Idutl2pan { get; set; }
        [Key]
        [Column("IDPAN")]
        public int Idpan { get; set; }
        [Column("QTEPRPAN")]
        public int? Qteprpan { get; set; }

        [ForeignKey(nameof(Idpan))]
        [InverseProperty(nameof(Produit.Paniers))]
        public virtual Produit IdpanNavigation { get; set; }
        [ForeignKey(nameof(Idutl2pan))]
        [InverseProperty(nameof(Utilisateur.Paniers))]
        public virtual Utilisateur Idutl2panNavigation { get; set; }
    }
}
