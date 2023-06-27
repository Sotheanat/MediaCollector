﻿using MediaCollector.Class;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WMPLib;

namespace MediaCollector.Form
{
    public partial class ctrDisplayCard : UserControl
    {
        private Movie movie;

        public ctrDisplayCard(Movie media)
        {
            InitializeComponent();
            this.movie = media;
            InitCard();
        }

        private void InitCard()
        {
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCover.ImageLocation = movie.CoverDir;
            lblTitle.Text = movie.FolderName;
        }
       public bool Contains (string FolderName) 
        {
            return this.movie.FolderName.ToLower().Contains(FolderName);
        }

        private void pbCover_DoubleClick(object sender, EventArgs e)
        {
            using (Process movieOpener = new Process())
            {
                movieOpener.StartInfo.FileName = movie.FileDir;
                movieOpener.Start();
            }
        }


        private void pbCover_Click(object sender, EventArgs e)
        {
            MouseEventArgs rightClick = ((MouseEventArgs)e);

            if(rightClick.Button == MouseButtons.Right) 
            {
                double durationInMinutes = new WindowsMediaPlayer().newMedia(movie.FileDir).duration/60;
                int hours = (int)durationInMinutes / 60;
                int minutes = (int)durationInMinutes % 60;


                ctmRightClick.Items["size"].Text = (new FileInfo(movie.FileDir).Length / (1024*1024)).ToString() + " MB" + " |  " + hours + "hr " + minutes + " min";
                ctmRightClick.Show(pbCover, rightClick.Location);
            }
        }

        private void openFileLocation_Click(object sender, EventArgs e)
        {
            using (Process movieOpener = new Process())
            {
                movieOpener.StartInfo.FileName = movie.FolderDir;
                movieOpener.Start();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult isYes = MessageBox.Show("Please comfirm the deletion.", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (isYes == DialogResult.Yes)
            {
                if (Directory.Exists(movie.FolderDir))
                {
                    // Move the directory and its contents to the recycle bin
                    FileSystem.DeleteDirectory(movie.FolderDir, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);


                    //delete a node XML File
                    // Load the XML file into an XmlDocument
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "ALL-MEDIA.xml");

                    // Find the node with the specified folder name
                    XmlNode nodeToDelete = xmlDoc.SelectSingleNode($"//Media[FolderName='{movie.FolderName}']");

                    // Delete the node if it exists
                    if (nodeToDelete != null)
                    {
                        nodeToDelete.ParentNode.RemoveChild(nodeToDelete);
                        xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "ALL-MEDIA.xml");
                    }

                    // Save the XmlDocument back to the file
                    xmlDoc.Save("ALL-MEDIA.xml");



                    // hide Card
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show($"Directory {movie.FolderDir} does not exist.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewCover_Click(object sender, EventArgs e)
        {
            using (Process movieOpener = new Process())
            {
                movieOpener.StartInfo.FileName = movie.CoverDir;
                movieOpener.Start();
            }
        }


        public void IndicateTheResult()
        {
            lblTitle.BackColor = Color.Yellow;
            Thread.Sleep(300);
            lblTitle.BackColor = Color.FromArgb(182, 226, 211);
            Thread.Sleep(300);
            lblTitle.BackColor = Color.Yellow;
            Thread.Sleep(300);
            lblTitle.BackColor = Color.FromArgb(182, 226, 211);
            Thread.Sleep(300);
            lblTitle.BackColor = Color.Yellow;
            Thread.Sleep(300);
            lblTitle.BackColor = Color.FromArgb(182, 226, 211);

        }
    }
}
