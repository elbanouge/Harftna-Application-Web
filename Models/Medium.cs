using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("MEDIA")]
    public partial class Medium
    {
        [Key]
        [Column("IDMED")]
        public int Idmed { get; set; }
        [Column("IDPMED")]
        public int? Idpmed { get; set; }
        [Column("IMAGEMED", TypeName = "image")]
        public byte[] Imagemed { get; set; }

        [ForeignKey(nameof(Idpmed))]
        [InverseProperty(nameof(Produit.Media))]
        public virtual Produit IdpmedNavigation { get; set; }
    }
}
