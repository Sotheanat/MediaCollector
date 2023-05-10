using MediaCollector.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaCollector.Form
{
    public partial class ctrDisplayCard : UserControl
    {
        private Media media;

        public ctrDisplayCard(Movie media)
        {
            InitializeComponent();
            this.media = media;
            InitCard();
        }

        private void InitCard()
        {
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCover.ImageLocation = media.CoverDir;
            lblTitle.Values.ExtraText = "";
            lblTitle.Values.Text = media.FolderName;
        }
       public bool Contains (string FolderName) 
        {
            return this.media.FolderName.ToLower().Contains(FolderName);
        }

    }
}
