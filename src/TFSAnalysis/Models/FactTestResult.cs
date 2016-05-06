using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("FactTestResult")]
    public partial class FactTestResult
    {
        [Key]
        public int TestResultSK { get; set; }

        [Required]
        [StringLength(128)]
        public string TestResultBK { get; set; }

        public int? DateResultRecordCount { get; set; }

        public int? BuildResultRecordCount { get; set; }

        public int? PointRecordCount { get; set; }

        public int? ResultCount { get; set; }

        public int? ResultTransitionCount { get; set; }

        public DateTime? ResultDate { get; set; }

        public int? PointId { get; set; }

        public int? ChangeNumber { get; set; }

        public int? TestCaseId { get; set; }

        public DateTime? CompleteDate { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public int? TeamProjectSK { get; set; }

        public int? ResultSK { get; set; }

        public int? TestResultAttributesSK { get; set; }

        public int? BuildSK { get; set; }

        public int? TestRunSK { get; set; }

        public int? AreaSK { get; set; }

        public int? IterationSK { get; set; }

        public DateTime? DateSK { get; set; }

        public int? TestPlanSK { get; set; }

        public int? BuildPlatformSK { get; set; }

        public int? BuildFlavorSK { get; set; }

        public int? ConfigurationSK { get; set; }

        public int? TestSuiteSK { get; set; }

        public int? RelatedWorkItemSK { get; set; }
    }
}
