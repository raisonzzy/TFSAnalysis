using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimPerson")]
    public partial class DimPerson
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DimPerson()
        //{
        //    DimChangeset = new HashSet<DimChangeset>();
        //}

        [Key]
        public int PersonSK { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string SID { get; set; }

        [StringLength(256)]
        public string Domain { get; set; }

        [StringLength(256)]
        public string Alias { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DimChangeset> DimChangeset { get; set; }
    }
}
