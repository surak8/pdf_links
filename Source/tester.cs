using System.Reflection;
using iTextSharp.text.pdf.parser;

namespace NSPdf_links {
    class tester : ITextExtractionStrategy {
        void IRenderListener.BeginTextBlock() {
            Logger.log(MethodBase.GetCurrentMethod());
        }

        void IRenderListener.EndTextBlock() {
            Logger.log(MethodBase.GetCurrentMethod());
        }

        string ITextExtractionStrategy.GetResultantText() {
            Logger.log(MethodBase.GetCurrentMethod());
            return null;
        }

        void IRenderListener.RenderImage(ImageRenderInfo renderInfo) {
            Logger.log(MethodBase.GetCurrentMethod());
        }

        void IRenderListener.RenderText(TextRenderInfo renderInfo) {
            Logger.log(MethodBase.GetCurrentMethod());
        }
    }
}