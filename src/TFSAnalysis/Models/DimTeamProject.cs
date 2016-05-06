using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimTeamProject")]
    public partial class DimTeamProject
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DimTeamProject()
        //{
        //    DimChangeset = new HashSet<DimChangeset>();
        //    DimTeamProject1 = new HashSet<DimTeamProject>();
        //}

        [Key]
        public int ProjectNodeSK { get; set; }

        public Guid ProjectNodeGUID { get; set; }

        [StringLength(256)]
        public string ProjectNodeName { get; set; }

        public int? ProjectNodeType { get; set; }

        [StringLength(256)]
        public string ProjectNodeTypeName { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(260)]
        public string ReportPath { get; set; }

        [StringLength(4000)]
        public string ProjectPath { get; set; }

        public int? Depth { get; set; }

        public int? ParentNodeSK { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DimChangeset> DimChangeset { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DimTeamProject> DimTeamProject1 { get; set; }

        //public virtual DimTeamProject DimTeamProject2 { get; set; }
    }
}
