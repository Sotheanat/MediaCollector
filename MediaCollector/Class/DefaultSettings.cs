using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollector.Class
{
    static class DefaultSettings
    {
        public enum CardSize { SMALL, MEDIUM, LARGE }; // use hash table is better
        public enum ThemeColor { DARK, PINK, RETRO, ZUPER, DEFAULT }

        public static Size mediumCardSize = new Size(365, 266);
        public static Size smallCardSize = new Size(248, 177);
        public static Size defaultOrLargeCardSize = new Size(483, 314);

        public static int defaultNumberOfCard = 40;
    }
}
