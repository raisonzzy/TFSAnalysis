using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimBuildPlatform")]
    public partial class DimBuildPlatform
    {
        [Key]
        public int BuildPlatformSK { get; set; }

        [Required]
        [StringLength(64)]
        public string BuildPlatformName { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }
        
    }
}
