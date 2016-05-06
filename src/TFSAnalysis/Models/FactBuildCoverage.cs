using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{

    [Table("FactBuildCoverage")]
    public partial class FactBuildCoverage
    {
        [Key]
        public int BuildCoverageSK { get; set; }

        [Required]
        [StringLength(128)]
        public string BuildCoverageBK { get; set; }

        public int? LinesCovered { get; set; }

        public int? LinesNotCovered { get; set; }

        public int? LinesPartiallyCovered { get; set; }

        public int? BlocksCovered { get; set; }

        public int? BlocksNotCovered { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public int? TeamProjectSK { get; set; }

        public int? BuildSK { get; set; }

        public int? AssemblySK { get; set; }

        public int? CodeElementSK { get; set; }

        public DateTime? DateSK { get; set; }

        public int? BuildPlatformSK { get; set; }

        public int? BuildFlavorSK { get; set; }
    }
}
