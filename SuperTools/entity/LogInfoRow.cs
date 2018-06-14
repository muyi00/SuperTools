using System;
using System.Collections.Generic;
using System.Text;

namespace CylinderArchiveRepair
{
    class LogInfoRow
    {
 
        /// <summary>
        /// 企业号
        /// </summary>
        public String corpCode { set; get; }
        /// <summary>
        /// 芯片号
        /// </summary>
        public String xpCode { set; get; }

        public LogInfoRow(String corpCode, String xpCode)
        {
            this.corpCode = corpCode;
            this.xpCode = xpCode;
        }



       public static String getLogInfoRow(LogInfoRow logInfo,Boolean isOnlyXpCode)
        {
            if (isOnlyXpCode)
            {
                return logInfo.xpCode;
            }
            else
            {
                return logInfo.corpCode + "," + logInfo.xpCode;
            }
        }
    }
}
