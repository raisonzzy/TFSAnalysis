using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFSAnalysis
{
    public class UnitTestOverViewInfo
    {
        /// <summary>
        /// 项目GUID
        /// </summary>
        public Guid? ProjectNodeGUID { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectNodeName { get; set; }
        /// <summary>
        /// 生成名称
        /// </summary>
        public string BuildName { get; set; }
        /// <summary>
        /// 生成标识
        /// </summary>
        public string BuildBK { get; set; }

        public int BuildSK { get; set; }
        /// <summary>
        /// 日期（不带时分秒）
        /// </summary>
        public DateTime Vdatetime { get; set; }
        /// <summary>
        /// 日期（生成时间，带时分秒）
        /// </summary>
        public DateTime? BuildStartTime { get; set; }
        public string BuildStartTimeFormat {
            get {
                if (BuildStartTime != null)
                    return BuildStartTime.Value.ToString("yyyy-MM-dd HH:mm");
                else
                    return "";
            }
        }
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
        public int FailedCount { get; set; }
        /// <summary>
        /// 通过数
        /// </summary>
        public int PassedCount { get; set; }
        /// <summary>
        /// 已覆盖数
        /// </summary>
        public int BlocksCovered { get; set; }
        /// <summary>
        /// 未覆盖数
        /// </summary>
        public int BlocksNotCovered { get; set; }
        /// <summary>
        /// 代码改动（行数）
        /// </summary>
        public int TotalChurn { get; set; }
        public byte OutcomeId { get; set; }
        /// <summary>
        ///覆盖率
        /// </summary>
        public decimal CodeCoverage { get; set; }
    }
}
