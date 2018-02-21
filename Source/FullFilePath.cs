using System;
using System.IO;

namespace NSPdf_links {
    public class FullFilePath {

        public FullFilePath(string aFile) {
            Uri uri;

            realPath = aFile;
            uri = new Uri(aFile);
            fullPath = uri.AbsoluteUri;
            filename = Path.GetFileNameWithoutExtension(aFile);
        }
        public string realPath { get; private set; }
        public string fullPath { get; set; }
        public string filename { get; set; }
    }
}
