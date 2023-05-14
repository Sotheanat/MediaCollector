using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollector.Class
{
    
    public class Movie : Media, ISerializable
    {
       
        public string FileDir { get;  set; }
        public double MovieLength { get; set; }
        public string[] ImagePreviewDir { get; set; }

        public Movie() { }

        public Movie(string coverDir, string folderDir, string folderName, string fileDir, double movieLength, string[] imagePreviewDir) : 
            base(coverDir, folderDir, folderName)
        {
            FileDir= fileDir; 
            MovieLength= movieLength; 
            ImagePreviewDir= imagePreviewDir;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Length: %d", MovieLength.ToString());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CoverDir", this.CoverDir);
            info.AddValue("FolderDir", this.FolderDir);
            info.AddValue("FolderName", this.FolderName);

            info.AddValue("FileDir", FileDir);
            info.AddValue("MovieLength", MovieLength);
            info.AddValue("ImagePreviewDir", ImagePreviewDir);
        }

        public Movie(SerializationInfo info, StreamingContext context): 
            base(info.GetValue("CoverDir", typeof(string)).ToString(), info.GetValue("FolderDir", typeof(string)).ToString(), info.GetValue("FolderName", typeof(string)).ToString())
        {
            //info.GetValue("CoverDir", typeof(string));
            //info.GetValue("FolderDir", typeof(string));
            //info.GetValue("FolderName", typeof(string));

            info.GetValue("FileDir", typeof(string));
            info.GetValue("MovieLength", typeof(double));
            info.GetValue("ImagePreviewDir", typeof(string[]));
        }

        ~Movie()
        {

        }
    }
}
