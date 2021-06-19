using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("ADMINISTRATEUR")]
    public partial class Administrateur
    {
        [Key]
        [Column("IDAD")]
        public int Idad { get; set; }
        [Column("LOGINAD")]
        [StringLength(25)]
        public string Loginad { get; set; }
        [Column("PASSAD")]
        [StringLength(25)]
        public string Passad { get; set; }
    }
}
