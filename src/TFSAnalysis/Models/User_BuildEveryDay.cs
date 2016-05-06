using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("User_BuildEveryDay")]
    public class User_BuildEveryDay
    {
        /// <summary>
        /// 生成标识
        /// </summary>
        [Key]
        public string BuildBK { get; set; }
        public DateTime? DateTime { get; set; }
        public string BuildDefinitionName { get; set; }
        public string BuildPlatformName { get; set; }
        public string BuildFlavorName { get; set; }
        public string BuildStatusName { get; set; }
        public int BuildStatus { get; set; }
        /// <summary>
        /// 通过数
        /// </summary>
        public int? NumBuilds { get; set; }
        /// <summary>
        /// 失败数
        /// </summary>
        public int? FailedCount { get; set; }
        /// <summary>
        /// 通过数
        /// </summary>
        public int? PassedCount { get; set; }
        /// <summary>
        /// 覆盖率
        /// </summary>
        public decimal? CodeCoverage { get; set; }
    }
}
