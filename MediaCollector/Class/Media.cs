using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MediaCollector.Class
{
    [XmlInclude(typeof(Movie))]
    [Serializable()]
    public class Media
    {
        /// <summary>
        /// A unique directory that need to be browsed to
        /// </summary>
        public static string RootFolder { get; set; }

        
        public string CoverDir { get;  set;}
        public string FolderDir { get;  set; }

        /// <summary>
        /// FolderName is the title of the media, it is used for display and search purposes. It is not unique, but it is required.
        /// </summary>
        public string FolderName { get;  set; }

        public Media()
        { }
        public Media(string coverDir, string folderDir, string folderName)
        {
            CoverDir = coverDir;
            FolderDir = folderDir;
            FolderName = folderName;
        }

        public override string ToString() 
        {
            return String.Format("Title: %s, ", FolderName);
        }

        ~Media()
        {

        }
        
    }
}
