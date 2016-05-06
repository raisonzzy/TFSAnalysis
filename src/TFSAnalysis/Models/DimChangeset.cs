using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimChangeset")]
    public partial class DimChangeset
    {
        [Key]
        public int ChangesetSK { get; set; }

        [Required]
        [StringLength(128)]
        public string ChangesetBK { get; set; }

        public int? ChangesetID { get; set; }

        [StringLength(128)]
        public string ChangesetTitle { get; set; }

        [StringLength(128)]
        public string PolicyOverrideComment { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public int? TeamProjectCollectionSK { get; set; }

        public int? CheckedInBySK { get; set; }
    }
}
