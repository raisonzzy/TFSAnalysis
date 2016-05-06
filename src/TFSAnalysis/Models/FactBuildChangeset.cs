using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("FactBuildChangeset")]
    public partial class FactBuildChangeset
    {
        [Key]
        public int BuildChangesetSK { get; set; }

        [Required]
        [StringLength(80)]
        public string BuildChangesetBK { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public int? TeamProjectSK { get; set; }

        public int? BuildSK { get; set; }

        public int? ChangesetSK { get; set; }
    }
}
