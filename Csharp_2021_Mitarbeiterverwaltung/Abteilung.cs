namespace Csharp_2021_Mitarbeiterverwaltung
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abteilung")]
    public partial class Abteilung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Abteilung()
        {
            Mitarbeiters = new HashSet<Mitarbeiter>();
        }

        [Key]
        public int AbteilungsNr { get; set; }

        [Required]
        [StringLength(50)]
        public string Bezeichnung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mitarbeiter> Mitarbeiters { get; set; }
    }
}
