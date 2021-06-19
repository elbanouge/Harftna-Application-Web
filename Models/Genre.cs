using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("GENRE")]
    public partial class Genre
    {
        public Genre()
        {
            Produits = new HashSet<Produit>();
        }

        [Key]
        [Column("IDGEN")]
        public int Idgen { get; set; }
        [Column("TYPEGEN")]
        [StringLength(25)]
        public string Typegen { get; set; }

        [InverseProperty(nameof(Produit.IdgproNavigation))]
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
