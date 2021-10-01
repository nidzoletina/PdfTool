using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace PdfTool.Tools
{
    internal static partial class PdfTools
    {
        internal static void JoinWith(string documentToJoinToPath, string documentToJoinPath)
        {
            using PdfDocument targetDocument = PdfReader.Open(documentToJoinToPath, PdfDocumentOpenMode.Modify);
            using PdfDocument inputDocument = PdfReader.Open(documentToJoinPath, PdfDocumentOpenMode.Import);

            foreach (var page in inputDocument.Pages)
                targetDocument.AddPage(page);

            targetDocument.Save(documentToJoinToPath);
        }
    }
}
