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
        public int eNumCardSize = 2;

        public Settings() 
        {
            //default is Large
            cardSize = new Size() { Height = 314, Width = 483 };
        }
        public Settings( Size size, int eNumCardSize)
        {
            this.eNumCardSize = eNumCardSize;

            cardSize = size;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue("CardSize", cardSize);
            info.AddValue("eNumCardSize", eNumCardSize);
        }

        public Settings(SerializationInfo info, StreamingContext context)
        {
            cardSize = (Size)info.GetValue("CardSize", typeof(Size));
            eNumCardSize = info.GetInt32("eNumCardSize");
        }
    }
}
