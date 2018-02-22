using System;
using System.IO;

namespace NSPdf_links {
    public class FullFilePath {
        #region fields
        static int _instance = 0;
        public readonly int instanceNo;
        #endregion

        #region ctors
        public FullFilePath(string aFile) : this(aFile, false) { }

        public FullFilePath(string aFile, bool needModel) {
            Uri uri;
            string fnameonly;
            int pos;

            instanceNo = ++_instance;
            realPath = aFile;
            uri = new Uri(aFile);
            fullPath = uri.AbsoluteUri;
            filename = Path.GetFileNameWithoutExtension(aFile);
            if (needModel) {
                fnameonly = Path.GetFileNameWithoutExtension(aFile);
                if ((pos = fnameonly.IndexOf('_')) >= 0) {
                    model = fnameonly.Substring(0, pos);
                    opNumber = fnameonly.Substring(pos + 1);
                    isValid = true;
                }
            }
        }
        #endregion

        #region properties
        public bool isValid { get; private set; }

        public string realPath { get; private set; }
        public string fullPath { get; private set; }
        public string filename { get; private set; }
        public string model { get; private set; }
        public string opNumber { get; private set; }
        #endregion
    }
}