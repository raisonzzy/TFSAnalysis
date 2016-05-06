using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("User_BuildOverView")]
    public class User_BuildOverView
    {
        /// <summary>
        /// 生成名称
        /// </summary>
        public string BuildName { get; set; }
        /// <summary>
        /// 生成标识
        /// </summary>
        public string BuildBK { get; set; }
        [Key]
        public int BuildSK { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? BuildStartTime { get; set; }
        public string BuildDefinitionName { get; set; }
        public string BuildStatusName { get; set; }
        public string BuildPlatformName { get; set; }
        public int BuildPlatformSK { get; set; }
        /// <summary>
        /// 生成配置（Debug/Release）
        /// </summary>
        public string BuildFlavorName { get; set; }
        public int BuildFlavorSK { get; set; }
        /// <summary>
        /// 生成品质
        /// </summary>
        public string BuildQualityName { get; set; }
        /// <summary>
        /// 失败数
        /// </summary>
        public int? FailedCount { get; set; }
        /// <summary>
        /// 通过数
        /// </summary>
        public int? PassedCount { get; set; }
        /// <summary>
        /// 已覆盖数
        /// </summary>
        public int? BlocksCovered { get; set; }
        /// <summary>
        /// 未覆盖数
        /// </summary>
        public int? BlocksNotCovered { get; set; }
        /// <summary>
        /// 代码改动（行数）
        /// </summary>
        public int? TotalChurn { get; set; }
        /// <summary>
        /// 覆盖率
        /// </summary>
        public decimal? CodeCoverage { get; set; }
    }
}
