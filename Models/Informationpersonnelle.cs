using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("INFORMATIONPERSONNELLE")]
    public partial class Informationpersonnelle
    {
        public Informationpersonnelle()
        {
            Commanders = new HashSet<Commander>();
        }

        [Key]
        [Column("IDINFO")]
        public int Idinfo { get; set; }
        [Column("IDUTL2INFO")]
        public int? Idutl2info { get; set; }
        [Column("ADRESSEUTLINFO", TypeName = "text")]
        public string Adresseutlinfo { get; set; }
        [Column("PAYSUTLINFO")]
        [StringLength(25)]
        public string Paysutlinfo { get; set; }
        [Column("CODEPOSTALUTLINFO")]
        [StringLength(25)]
        public string Codepostalutlinfo { get; set; }

        [ForeignKey(nameof(Idutl2info))]
        [InverseProperty(nameof(Utilisateur.Informationpersonnelles))]
        public virtual Utilisateur Idutl2infoNavigation { get; set; }
        [InverseProperty(nameof(Commander.IdinfocomNavigation))]
        public virtual ICollection<Commander> Commanders { get; set; }
    }
}
