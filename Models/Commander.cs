using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("COMMANDER")]
    public partial class Commander
    {
        [Key]
        [Column("IDPCOM")]
        public int Idpcom { get; set; }
        [Key]
        [Column("IDINFOCOM")]
        public int Idinfocom { get; set; }
        [Key]
        [Column("IDLIVCOM")]
        public int Idlivcom { get; set; }
        [Column("DATECOMCOM", TypeName = "datetime")]
        public DateTime? Datecomcom { get; set; }
        [Column("PRIXCOM", TypeName = "money")]
        public decimal? Prixcom { get; set; }
        [Column("QTECOM")]
        public int? Qtecom { get; set; }
        [Column("ETATCOM")]
        [StringLength(25)]
        public string Etatcom { get; set; }

        [ForeignKey(nameof(Idinfocom))]
        [InverseProperty(nameof(Informationpersonnelle.Commanders))]
        public virtual Informationpersonnelle IdinfocomNavigation { get; set; }
        [ForeignKey(nameof(Idlivcom))]
        [InverseProperty(nameof(Livraison.Commanders))]
        public virtual Livraison IdlivcomNavigation { get; set; }
        [ForeignKey(nameof(Idpcom))]
        [InverseProperty(nameof(Produit.Commanders))]
        public virtual Produit IdpcomNavigation { get; set; }
    }
}
