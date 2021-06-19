using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("SOCIETE")]
    public partial class Societe
    {
        public Societe()
        {
            Livraisons = new HashSet<Livraison>();
        }

        [Key]
        [Column("IDSOC")]
        public int Idsoc { get; set; }
        [Column("IDLIVSOC")]
        public int? Idlivsoc { get; set; }
        [Column("NOMSOC")]
        [StringLength(25)]
        public string Nomsoc { get; set; }

        [InverseProperty(nameof(Livraison.IdsoslivNavigation))]
        public virtual ICollection<Livraison> Livraisons { get; set; }
    }
}
