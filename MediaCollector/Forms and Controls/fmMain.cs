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
using System.Runtime.InteropServices;
using System.Threading;
using MediaCollector.Forms_and_Controls;

namespace MediaCollector
{
    public partial class fmMain : KryptonForm
    {

        /// <summary>
        /// Program setting 
        Settings mySetting;

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
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dir = new FolderBrowserDialog();

            if (DialogResult.OK == dir.ShowDialog())
            {
                fmLoadingForm loadingForm = new fmLoadingForm();
                loadingForm.Show();

                ClearData(); 
                rootFolder = dir.SelectedPath;
                ScanDirectoryForMovies();

                //write media LIST here XML File
                SaveToXML();

                //add data displayCard Control
                InitDisplayCardControls();

                loadingForm.Close();
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
            //get cardSize from xml -> mySetting
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml"))
            {
                using (FileStream read = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "ProgramSettings.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
                    mySetting = (Settings)xmlSerializer.Deserialize(read);
                }
            }
            else { mySetting = new Settings(DefaultSettings.defaultOrLargeCardSize.Width, DefaultSettings.defaultOrLargeCardSize.Height); }



            //Set up condition for page
            //Declared at line 260
            TOTAL_ITEMS = medias.Count;
            TOTAL_PAGE = (TOTAL_ITEMS/mySetting.itemPerPage);
            CURRENT_PAGE = 0;

            for (int i = 0; i < Math.Min(medias.Count, mySetting.itemPerPage); i++)
            {
                flpMain.Controls.Add(
                        new ctrDisplayCard((Movie)medias[i])
                        {
                            Width = mySetting.cardSize.Width,
                            Height = mySetting.cardSize.Height
                        }
                    );
            }

            btnPrevious.Enabled = false;
            btnNext.Enabled = (TOTAL_PAGE > CURRENT_PAGE);

            UpdateLablePage();

            //flpMain.Focus();
            //if(flpMain.Controls.Count > 0)
            //    flpMain.ScrollControlIntoView(flpMain.Controls[flpMain.Controls.Count - 1]);

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            fmLoadingForm loadingForm = new fmLoadingForm();
            loadingForm.Show();

            LoadDataFromXML();
            InitDisplayCardControls();
            
            loadingForm.Close();
        }

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


        // Search by scrolling to the Controls
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
                    { 
                        flpMain.ScrollControlIntoView(card);


                        //new Thread(Indicate => card.IndicateTheResult()).Start();                   //not controlled
                        ThreadPool.QueueUserWorkItem(Indicate => card.IndicateTheResult());  //better 

                        break; 
                    }
                }
            }
        }

        private void pbLoading_Click(object sender, EventArgs e)
        {
            if(((MouseEventArgs)e).Button == MouseButtons.Left)
                flpMain.ScrollControlIntoView(flpMain.Controls[0]);
         }

        private void pbLoading_DoubleClick(object sender, EventArgs e)
        {
            flpMain.ScrollControlIntoView(flpMain.Controls[flpMain.Controls.Count - 1]);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new fmSetting().ShowDialog();
        }



        //Page variables are all here
        //
        /// Item in page
        //const int ITEM_PER_PAGE ;
        int TOTAL_ITEMS;

        //page
        int TOTAL_PAGE;
        int CURRENT_PAGE;



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CURRENT_PAGE < TOTAL_PAGE - 1)
            {
                CURRENT_PAGE++;
                UpdateDisplayedItems();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CURRENT_PAGE > 0)
            {
                CURRENT_PAGE--;
                UpdateDisplayedItems();
            }
        }

        private void UpdateDisplayedItems()
        {
            // Clear the previous controls
            flpMain.Controls.Clear();

            // Calculate the range of items for the current page
            int startIndex = CURRENT_PAGE * mySetting.itemPerPage;
            int endIndex = (CURRENT_PAGE == TOTAL_PAGE - 1) ? Math.Max(startIndex + mySetting.itemPerPage, TOTAL_ITEMS) : Math.Min(startIndex + mySetting.itemPerPage, TOTAL_ITEMS);

            // Add the controls for the current page
            for (int i = startIndex; i < endIndex; i++)
            {
                Media media = medias[i];
                flpMain.Controls.Add(
                    new ctrDisplayCard((Movie)media)
                    {
                        Width = mySetting.cardSize.Width,
                        Height = mySetting.cardSize.Height
                    }
                );
            }

            // Enable or disable navigation buttons based on the current page
            btnNext.Enabled = (CURRENT_PAGE < TOTAL_PAGE-1);
            btnPrevious.Enabled = (CURRENT_PAGE > 0);

            UpdateLablePage();
        }

        private void UpdateLablePage()
        {
            lblPage.Text = CURRENT_PAGE+1 + "/" + ((TOTAL_PAGE==0)? 1: TOTAL_PAGE);
        }

    }
}


