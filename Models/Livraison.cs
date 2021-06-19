using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("LIVRAISON")]
    public partial class Livraison
    {
        public Livraison()
        {
            Commanders = new HashSet<Commander>();
        }

        [Key]
        [Column("IDLIV")]
        public int Idliv { get; set; }
        [Column("IDSOSLIV")]
        public int? Idsosliv { get; set; }
        [Column("MODELIV")]
        [StringLength(25)]
        public string Modeliv { get; set; }
        [Column("PRIXLIV", TypeName = "money")]
        public decimal? Prixliv { get; set; }

        [ForeignKey(nameof(Idsosliv))]
        [InverseProperty(nameof(Societe.Livraisons))]
        public virtual Societe IdsoslivNavigation { get; set; }
        [InverseProperty(nameof(Commander.IdlivcomNavigation))]
        public virtual ICollection<Commander> Commanders { get; set; }
    }
}
