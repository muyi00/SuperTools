using System;
using System.Collections.Generic;
using System.Text;

namespace CylinderArchiveRepair
{
    class CorpXpCount
    {
        public String corpCode { set; get; }
        public int count { set; get; }
        public int emptyCount { set; get; }

        public CorpXpCount(String corpCode, int count, int emptyCount)
        {
            this.corpCode = corpCode;
            this.count = count;
            this.emptyCount = emptyCount;
        }



        public static int getCorpCodeIndex(List<CorpXpCount> corpXpCounts , String corpCode)
        {
            for (int i = 0; i < corpXpCounts.Count; i++)
            {

                if (corpCode==corpXpCounts[i].corpCode)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
