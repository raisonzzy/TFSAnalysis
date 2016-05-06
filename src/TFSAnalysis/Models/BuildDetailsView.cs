using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("BuildDetailsView")]
    public partial class BuildDetailsView
    {
        [Key]
        [StringLength(80)]
        public string BuildDetailsBK { get; set; }

        public long? BuildDuration { get; set; }

        public Guid? TeamProjectProjectNodeGUID { get; set; }

        [StringLength(256)]
        public string TeamProjectProjectNodeName { get; set; }

        public int? TeamProjectProjectNodeType { get; set; }

        [StringLength(256)]
        public string TeamProjectProjectNodeTypeName { get; set; }

        public bool? TeamProjectIsDeleted { get; set; }

        [StringLength(260)]
        public string TeamProjectReportPath { get; set; }

        [StringLength(4000)]
        public string TeamProjectProjectPath { get; set; }

        public int? TeamProjectDepth { get; set; }

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
        public string BuildDropLocation { get; set; }

        public DateTime? BuildStartTime { get; set; }

        public int? BuildTeamProjectCollectionSK { get; set; }

        public DateTime? DateTime { get; set; }

        public DateTime? DateYear { get; set; }

        [StringLength(30)]
        public string DateYearString { get; set; }

        public DateTime? DateMonth { get; set; }

        [StringLength(30)]
        public string DateMonthString { get; set; }

        public int? DateMonthOfYear { get; set; }

        public DateTime? DateWeek { get; set; }

        [StringLength(30)]
        public string DateWeekString { get; set; }

        public int? DateWeekOfYear { get; set; }

        [StringLength(30)]
        public string Date { get; set; }

        public int? DateDayOfYear { get; set; }

        public int? DateDayOfMonth { get; set; }

        public int? DateDayOfWeek { get; set; }

        [StringLength(256)]
        public string BuildQualityName { get; set; }

        [StringLength(256)]
        public string BuildStatusName { get; set; }

        public int? BuildStatusNameId { get; set; }

        [StringLength(256)]
        public string LastUpdatedByName { get; set; }

        [StringLength(256)]
        public string LastUpdatedBySID { get; set; }

        [StringLength(256)]
        public string LastUpdatedByDomain { get; set; }

        [StringLength(256)]
        public string LastUpdatedByAlias { get; set; }

        [StringLength(256)]
        public string LastUpdatedByEmail { get; set; }
    }
}
