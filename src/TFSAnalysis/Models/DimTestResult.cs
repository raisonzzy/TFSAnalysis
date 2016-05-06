using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("DimTestResult")]
    public partial class DimTestResult
    {
        
        [Key]
        public int ResultSK { get; set; }

        [Required]
        [StringLength(100)]
        public string ResultBK { get; set; }

        [StringLength(36)]
        public string ResultId { get; set; }

        [StringLength(36)]
        public string TestCaseId { get; set; }

        [StringLength(36)]
        public string ExecutionId { get; set; }

        [StringLength(256)]
        public string Test { get; set; }

        [StringLength(64)]
        public string ComputerName { get; set; }

        [StringLength(64)]
        public string Outcome { get; set; }

        public byte? OutcomeId { get; set; }

        [StringLength(64)]
        public string ReadinessState { get; set; }

        public byte? ReadinessStateId { get; set; }

        [StringLength(512)]
        public string ErrorMessage { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? DateCompleted { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? Duration { get; set; }

        [StringLength(256)]
        public string ResolutionState { get; set; }

        [StringLength(64)]
        public string FailureType { get; set; }

        public byte? FailureTypeId { get; set; }

        public byte? Priority { get; set; }

        public int? TestCaseRevision { get; set; }

        [StringLength(64)]
        public string TestTypeId { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public int? TeamProjectCollectionSK { get; set; }

        public int? OwnerSK { get; set; }

        public int? ExecutedBySK { get; set; }

        public int? AreaSK { get; set; }

        public int? IterationSK { get; set; }

        public int? TestResultAttributesSK { get; set; }
    }
}
