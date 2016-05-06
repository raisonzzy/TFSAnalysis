using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFSAnalysis
{
    public class ChangesetInfo
    {
        public int PersonSK { get; set; }
        /// <summary>
        /// 签入人
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 签入量
        /// </summary>
        public int ChangeCount { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public string LastUpdatedDateTimeFormat
        {
            get
            {
                return LastUpdatedDateTime.ToString("yyyy-MM-dd HH:mm");
            }
        }
        public string ChangesetTitle { get; set; }
    }
}
