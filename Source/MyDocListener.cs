using System;
using System.Reflection;
using iTextSharp.text;

namespace NSPdf_links {
    class MyDocListener : IDocListener {
        #region fields
        bool disposedValue = false; // To detect redundant calls
        int _pageCount;
        bool _newPage;
        bool _setMarginMirror;
        bool _setMargin;
        bool _setPageSize;
        bool _setMarginMirrorTB;
        #endregion

        public int PageCount {
            set {
                Logger.log(MethodBase.GetCurrentMethod(), "setting to " + value);
                _pageCount = value;
                //return _pageCount;
            }
        }

        public bool Add(IElement element) {
            Logger.log(MethodBase.GetCurrentMethod());
            throw new NotImplementedException();
        }

        public void Close() {
            Logger.log(MethodBase.GetCurrentMethod());
            //throw new NotImplementedException();
        }

        public bool NewPage() {
            Logger.log(MethodBase.GetCurrentMethod());
            return _newPage;
        }

        public void Open() {
            Logger.log(MethodBase.GetCurrentMethod());
        }

        public void ResetPageCount() {
            Logger.log(MethodBase.GetCurrentMethod());
            _pageCount = 0;
        }

        public bool SetMarginMirroring(bool marginMirroring) {
            Logger.log(MethodBase.GetCurrentMethod());
            return _setMarginMirror;
        }

        public bool SetMarginMirroringTopBottom(bool marginMirroringTopBottom) {
            Logger.log(MethodBase.GetCurrentMethod());
            return _setMarginMirrorTB;
        }

        public bool SetMargins(float marginLeft, float marginRight, float marginTop, float marginBottom) {
            Logger.log(MethodBase.GetCurrentMethod());
            return _setMargin;
        }

        public bool SetPageSize(Rectangle pageSize) {
            Logger.log(MethodBase.GetCurrentMethod());
            return _setPageSize;
        }

        #region IDisposable Support


        protected virtual void Dispose(bool disposing) {
            Logger.log(MethodBase.GetCurrentMethod(), "here-0");
            if (!disposedValue) {
                Logger.log(MethodBase.GetCurrentMethod(), "here-1");
                if (disposing) {
                    Logger.log(MethodBase.GetCurrentMethod(), "here-2");
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MyListener2() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose() {
            Logger.log(MethodBase.GetCurrentMethod(), "here");
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }

}