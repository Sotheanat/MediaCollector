using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MediaCollector.Class;
using System.Xml.Serialization;
using MediaCollector.Form;

namespace MediaCollector
{
    public partial class fmMain : KryptonForm
    {

        /// <summary>
        /// Program setting 
        /// </summary>
        //private int numberOfDisplayCard = 18;
        private string rootFolder;
        private string mediaFileName = "ALL-MEDIA.xml";

        /// <summary>
        /// Fields
        /// </summary>
        List<Media> medias = new List<Media>();

        public fmMain()
        {
            InitializeComponent();
            //LoadDataFromXML();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dir = new FolderBrowserDialog();

            if (DialogResult.OK == dir.ShowDialog())
            {
                ClearData(); 
                rootFolder = dir.SelectedPath;
                ScanDirectoryForMovies();

                //write media LIST here XML File
                SaveToXML();

                //add data displayCard Control
                InitDisplayCardControls();
            }

            
        }

        private void ClearData()
        {
            flpMain.Controls.Clear();
            medias = null; 
            medias = new List<Media>();
        }

        private void SaveToXML() 
        {
                using (FileStream writer = new FileStream(AppDomain.CurrentDomain.BaseDirectory + mediaFileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
                xmlSerializer.Serialize(writer, medias);
            }
        }

        private void LoadDataFromXML()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + mediaFileName))
            {
                using (FileStream read = new FileStream(AppDomain.CurrentDomain.BaseDirectory + mediaFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
                    medias = (List<Media>)xmlSerializer.Deserialize(read);
                }
            }
        }

        private void ScanDirectoryForMovies()
        {
            if (Directory.Exists(rootFolder))
            {
                string[] Medias = Directory.GetDirectories(rootFolder);
                Media.RootFolder = rootFolder;


                //get media from folder
                foreach (string media in Medias)
                {
                    //if movie dir is not empty
                    if (Directory.GetFiles(media).Length > 0)
                    {
                        //find movie & image file
                        var movieFileDir = (from file in Directory.GetFiles(media) where file.Contains(".mp4") select file);
                        var imageFileDir = from file in Directory.GetFiles(media) where file.Contains(".jpg") select file;

                        //Future Update
                        //var mp3FileDir = from file in Directory.GetFiles(media) where file.Contains(".mp3") select file;

                        //if there are mp4 and jpg
                        if (movieFileDir.ToArray().Length > 0 && imageFileDir.ToArray().Length > 0)
                        {
                            string movDir = movieFileDir.ToArray()[0];
                            string imgDir = imageFileDir.ToArray()[0];

                            //Low performace
                            //double duration = new WindowsMediaPlayer().newMedia(movDir).duration;
                            // previewImgDir = ...

                            //add movie to list
                            medias.Add(new Movie(imgDir, media, media.Remove(0, media.LastIndexOf('\\') + 1), movDir, 0.00, null));

                        }
                        /**
                         * else if there are mp3 and jpg
                         * then add to music class
                        **/

                    }

                }

            }
        }

        private void InitDisplayCardControls()
        {
            foreach (Media media in medias)
            {
                flpMain.Controls.Add(new ctrDisplayCard((Movie)media));
            }

            flpMain.Focus();

            if(flpMain.Controls.Count > 0)
                flpMain.ScrollControlIntoView(flpMain.Controls[flpMain.Controls.Count - 1]);
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            LoadDataFromXML();
            InitDisplayCardControls();
        }




        // Create A form for search so that searching process use less RAM
        //START FROM HERE
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search"))
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void pnMenu_Click(object sender, EventArgs e)
        {
            pnMenu.Focus();
        }


        // Search by hide Controls
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            
            if(txtSearch.Text.Count() > 1) 
            {
                string searchStr = txtSearch.Text;

                // Visible = false for ctrl that has different name
                foreach (Control ctrl in flpMain.Controls)
                {
                    ctrDisplayCard card = ctrl as ctrDisplayCard;

                    if (card.Contains(searchStr.ToLower()))
                    { flpMain.ScrollControlIntoView(card); break; }
                }
            }
        }


        private void pbLoading_Click(object sender, EventArgs e)
        {
            flpMain.ScrollControlIntoView(flpMain.Controls[0]);
         }

        private void pbLoading_DoubleClick(object sender, EventArgs e)
        {
            flpMain.ScrollControlIntoView(flpMain.Controls[flpMain.Controls.Count - 1]);
        }

        // HERE FROM ABOVE
    }
}


