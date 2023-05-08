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

namespace MediaCollector
{
    public partial class fmMain : KryptonForm
    {
        /// <summary>
        /// Program setting 
        /// </summary>
        //private int numberOfDisplayCard = 4;
        private string dirMain = "";
        private string mediaFile = "ALL-MEDIA.xml";

        /// <summary>
        /// Fields
        /// </summary>
        List<Control> controlList = new List<Control>();
        List<Media> medias = new List<Media>();

        public fmMain()
        {
            InitializeComponent();
            LoadDataFromXML();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dir = new FolderBrowserDialog();

            if (DialogResult.OK == dir.ShowDialog())
            {
                dirMain = dir.SelectedPath;
                ScanDirectoryForMovies();

                //write media LIST here XML File
                SaveToXML();
            }

            //TODO...
            //add data displayCard Control
        }

        private void SaveToXML() 
        {
            using (TextWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + mediaFile))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
                xmlSerializer.Serialize(writer, medias);
            }
        }

        private void LoadDataFromXML()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + mediaFile))
            {
                using (FileStream read = new FileStream(AppDomain.CurrentDomain.BaseDirectory + mediaFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
                    medias = (List<Media>)xmlSerializer.Deserialize(read);
                }
            }
        }

        private void ScanDirectoryForMovies()
        {
            if (Directory.Exists(dirMain))
            {
                string[] Medias = Directory.GetDirectories(dirMain);
                Media.RootFolder = dirMain;


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




    }
}


