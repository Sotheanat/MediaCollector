using ComponentFactory.Krypton.Toolkit;
using MediaCollector.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MediaCollector.Forms_and_Controls
{
    public partial class fmSetting : KryptonForm
    {
        Settings mySetting;
        public enum CardSize { SMALL, MEDIUM, LARGE };
        public enum ThemeColor { DARK, PINK, RETRO, ZUPER, DEFAULT }


        public fmSetting()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Color[] color = new Color[4];
            Size size= new Size();
            int s = 2;
            int c = 4;

                if (rdSmall.Checked)
                {
                    size.Width = 248;
                    size.Height = 177;
                    s = (int)CardSize.SMALL;                
                }
                else if (rdMedium.Checked)
                {
                    size.Width = 365;
                    size.Height = 266;
                    s = (int)CardSize.MEDIUM;
                }
                else if (rdLarge.Checked)
                {
                    size.Width = 483;
                    size.Height = 314;
                    s = (int)CardSize.LARGE;
                }


                if (rdDark.Checked)
                {
                    color[0] = ColorTranslator.FromHtml("#000C66");   //header
                    color[1] = ColorTranslator.FromHtml("#7EC8E3");  //Panel
                    color[2] = ColorTranslator.FromHtml("#0000FF");   // Line Under CardDisplay Control
                    color[3] = ColorTranslator.FromHtml("#050A30");  //font

                    c = (int)ThemeColor.DARK;
                }
                else if (rdPink.Checked)
                {
                    color[0] = ColorTranslator.FromHtml("#D8A7B1"); //header
                    color[1] =ColorTranslator.FromHtml("#FAE8E0");  //Panel
                    color[2] = ColorTranslator.FromHtml("#B6E2D3"); // Line Under CardDisplay Control
                    color[3] = ColorTranslator.FromHtml("#EF7C8E"); //font

                    c = (int)ThemeColor.PINK;
            }
                else if (rdRetro.Checked)
                {
                    color[0] = ColorTranslator.FromHtml("#F8D210");
                    color[1] = ColorTranslator.FromHtml("#F51720");
                    color[2] = ColorTranslator.FromHtml("#FA26A0");
                    color[3] = ColorTranslator.FromHtml("#2FF3E0");

                    c = (int)ThemeColor.RETRO;
                }
                else if (rdZuper.Checked)
                {
                    color[0] = ColorTranslator.FromHtml("#74BDCB");
                    color[1] = ColorTranslator.FromHtml("#EFE7BC");
                    color[2] = ColorTranslator.FromHtml("#FFA384");
                    color[3] = ColorTranslator.FromHtml("#E7F2F8");

                    c = (int)ThemeColor.ZUPER;
                }




            //Save to XML
            
            mySetting = new Settings(color, c, size, s);

            using (FileStream writer = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
                xmlSerializer.Serialize(writer, mySetting);
            }

        }



        private void fmSetting_Load(object sender, EventArgs e)
        {
            //read xml file

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml"))
            {
                using (FileStream read = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
                    mySetting = (Settings)xmlSerializer.Deserialize(read);
                }

                switch (mySetting.eNumThemeColor)
                {
                    case (int)ThemeColor.RETRO:
                        rdRetro.Checked= true;
                        break;

                        //case 2 ,3 ,4...
                }


                switch (mySetting.eNumCardSize)
                {
                    case (int)CardSize.LARGE: rdLarge.Checked = true;
                        break;

                        //Small, medium..
                }

            }
            else
            {
                rdPink.Checked = true;
                rdLarge.Checked = true;
            }
        }




        [Serializable()]
        private class Settings : ISerializable
        {
            public Color[] themeColor = new Color[4];
            public int eNumThemeColor = 4;

            public Size cardSize;
            public int eNumCardSize = 2;
            public Settings(Color[] color, int eNumThemeColor, Size size, int eNumCardSize)
            {
                themeColor = color;
                this.eNumCardSize = eNumCardSize;

                cardSize = size;
                this.eNumThemeColor = eNumThemeColor;
            }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("ThemeColor", themeColor);
                info.AddValue("eNumThemeColor", eNumThemeColor);

                info.AddValue("CardSize", cardSize);
                info.AddValue("eNumCardSize", eNumCardSize);
            }

            public Settings(SerializationInfo info, StreamingContext context)
            {
                info.GetValue("ThemeColor", typeof(Color));
                info.GetValue("CardSize", typeof(Size));

                info.GetValue("eNumThemeColor", typeof(int));
                info.GetValue("eNumCardSize", typeof(int));
            }
        }



    }
}
