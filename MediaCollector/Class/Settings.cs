using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollector.Class
{

    [Serializable()]
    public class Settings : ISerializable
    {
        public Size cardSize;
        public int eNumCardSize;
        public int itemPerPage;
 
        public Settings() { }
        public Settings(int W = 483, int H = 314, int eNumCardSize = 2, int iTEM_PER_PAGE = 40)
        {
            this.eNumCardSize = eNumCardSize;
            cardSize = new Size(W,H);
            itemPerPage = iTEM_PER_PAGE;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue("CardSize", cardSize);
            info.AddValue("eNumCardSize", eNumCardSize);
            info.AddValue("iTEM_PER_PAGE", itemPerPage);
        }

        public Settings(SerializationInfo info, StreamingContext context)
        {
            cardSize = (Size)info.GetValue("CardSize", typeof(Size));
            eNumCardSize = info.GetInt32("eNumCardSize");
            itemPerPage = info.GetInt32("iTEM_PER_PAGE");
        }
    }
}
