namespace Csharp_2021_Mitarbeiterverwaltung
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mitarbeiter")]
    public partial class Mitarbeiter
    {
        [Key]
        public int PersonalNr { get; set; }

        public int AbteilungsNr { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Vorname { get; set; }

        [Required]
        [StringLength(50)]
        public string Stellenbezeichnung { get; set; }

        [Required]
        [StringLength(50)]
        public string Adresse { get; set; }

        [Required]
        [StringLength(5)]
        public string PLZ { get; set; }

        [Required]
        [StringLength(50)]
        public string Ort { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefon { get; set; }

        public virtual Abteilung Abteilung { get; set; }
    }
}
