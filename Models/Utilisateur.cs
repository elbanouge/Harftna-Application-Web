using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("UTILISATEUR")]
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Avis = new HashSet<Avi>();
            Fournisseurs = new HashSet<Fournisseur>();
            Informationpersonnelles = new HashSet<Informationpersonnelle>();
            Paniers = new HashSet<Panier>();
            Singlers = new HashSet<Singler>();
        }

        [Key]
        [Column("IDUTL2")]
        public int Idutl2 { get; set; }
        [Column("NOMUTL")]
        [StringLength(25)]
        public string Nomutl { get; set; }
        [Column("PRENOMUTL")]
        [StringLength(25)]
        public string Prenomutl { get; set; }
        [Column("MOTPASSUTL")]
        [StringLength(25)]
        public string Motpassutl { get; set; }
        [Column("EMAILUTL")]
        [StringLength(25)]
        public string Emailutl { get; set; }
        [Column("TELUTL")]
        [StringLength(25)]
        public string Telutl { get; set; }
        [Column("CINPASSUTL")]
        [StringLength(25)]
        public string Cinpassutl { get; set; }
        [Column("IMAGEUTL", TypeName = "image")]
        public byte[] Imageutl { get; set; }
        [Column("SCOREUTL")]
        [StringLength(25)]
        public string Scoreutl { get; set; }
        [Column("IPUTL")]
        [StringLength(25)]
        public string Iputl { get; set; }
        [Column("EMAILVERIFIER")]
        public bool? Emailverifier { get; set; }
        [Column("DATECREATE", TypeName = "datetime")]
        public DateTime? Datecreate { get; set; }

        [InverseProperty(nameof(Avi.Idutl2aviNavigation))]
        public virtual ICollection<Avi> Avis { get; set; }
        [InverseProperty(nameof(Fournisseur.IdutlfourNavigation))]
        public virtual ICollection<Fournisseur> Fournisseurs { get; set; }
        [InverseProperty(nameof(Informationpersonnelle.Idutl2infoNavigation))]
        public virtual ICollection<Informationpersonnelle> Informationpersonnelles { get; set; }
        [InverseProperty(nameof(Panier.Idutl2panNavigation))]
        public virtual ICollection<Panier> Paniers { get; set; }
        [InverseProperty(nameof(Singler.Idutl2singNavigation))]
        public virtual ICollection<Singler> Singlers { get; set; }
    }
}
