﻿using ComponentFactory.Krypton.Toolkit;
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

        public fmSetting()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Size size= new Size();
            int eNumCardSize = 2;
            int itemPerPage = Convert.ToInt32(numCard.Value);

                if (rdSmall.Checked)
                {
                    size.Width = 248;
                    size.Height = 177;
                eNumCardSize = (int)DefaultSettings.CardSize.SMALL;
                }
                else if (rdMedium.Checked)
                {
                    size.Width = 365;
                    size.Height = 266;
                    eNumCardSize = (int)DefaultSettings.CardSize.MEDIUM;
                }
                else if (rdLarge.Checked)
                {
                    size.Width = 483;
                    size.Height = 314;
                    eNumCardSize = (int)DefaultSettings.CardSize.LARGE;
                }

            //Save setting file to XML  

            mySetting = new Settings(size.Width,size.Height, eNumCardSize, itemPerPage);

            using (FileStream writer = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
                xmlSerializer.Serialize(writer, mySetting);

                MessageBox.Show("Please restart to take effect.", "Require", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void fmSetting_Load(object sender, EventArgs e)
        {
            //read xml file

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml"))
            {
                using (FileStream read = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
                    mySetting = (Settings)xmlSerializer.Deserialize(read);
                }


                switch (mySetting.eNumCardSize)
                {
                    case (int)DefaultSettings.CardSize.LARGE: 
                        rdLarge.Checked = true;
                        break;
                    case (int)DefaultSettings.CardSize.MEDIUM:
                        rdMedium.Checked = true;
                        break;
                    case (int)DefaultSettings.CardSize.SMALL:
                        rdSmall.Checked = true;
                        break;
                }

                numCard.Value= mySetting.itemPerPage;

            }
            else
            {
                rdPink.Checked = true;
                rdLarge.Checked = true;
                numCard.Value = 40;
            }
        }

    }
}
