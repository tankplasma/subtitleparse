using System;
using System.Collections.Generic;

namespace SubtitlesParser
{
    public class SubtitleItem
    {

        //  Propriétés
        
        //les temps sont en millisecondes
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public List<string> Lines { get; set; }
        

        // les constructeurs
        public SubtitleItem()
        {
            this.Lines = new List<string>();
        }


        // les methodes

        public override string ToString()
        {
            var startTs = new TimeSpan(0, 0, 0, 0, StartTime);
            var endTs = new TimeSpan(0, 0, 0, 0, EndTime);

            var res = string.Format("{0} --> {1}: {2}", startTs.ToString("G"), endTs.ToString("G"), string.Join(Environment.NewLine, Lines));
            return res;
        }

    }
}