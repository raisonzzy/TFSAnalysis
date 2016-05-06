using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimBuild")]
    public partial class DimBuild
    {
        [Key]
        public int BuildSK { get; set; }

        [Required]
        [StringLength(64)]
        public string BuildBK { get; set; }

        [StringLength(64)]
        public string BuildID { get; set; }

        [StringLength(260)]
        public string BuildName { get; set; }

        [StringLength(260)]
        public string BuildType { get; set; }

        [StringLength(260)]
        public string BuildDefinitionName { get; set; }

        [StringLength(512)]
        public string DropLocation { get; set; }

        public DateTime? BuildStartTime { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public int? TeamProjectCollectionSK { get; set; }
    }
}
