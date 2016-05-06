using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimBuildFlavor")]
    public partial class DimBuildFlavor
    {
        [Key]
        public int BuildFlavorSK { get; set; }

        [Required]
        [StringLength(64)]
        public string BuildFlavorName { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }
    }
}
