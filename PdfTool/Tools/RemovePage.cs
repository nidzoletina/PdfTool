using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace PdfTool.Tools
{
    internal static partial class PdfTools
    {
        internal static void RemovePage(string filepath, int pageNumber)
        {
            using PdfDocument pdfDocument = PdfReader.Open(filepath, PdfDocumentOpenMode.Modify);
            pdfDocument.Pages.RemoveAt(pageNumber - 1);
            pdfDocument.Save(filepath);
        }
    }
}
