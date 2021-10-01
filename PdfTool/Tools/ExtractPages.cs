using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace PdfTool.Tools
{
    internal static partial class PdfTools
    {
        internal static void ExtractPages(string filepath, int extractionStart, int extractionEnd)
        {
            using PdfDocument SourceDocument = PdfReader.Open(filepath, PdfDocumentOpenMode.Import);
            using PdfDocument newDocument = new();

            for (int i = extractionStart - 1; i < extractionEnd; i++)
                newDocument.AddPage(SourceDocument.Pages[i]);

            string savePath = filepath.Replace(".pdf", $" pages {extractionStart}-{extractionEnd}.pdf");
            newDocument.Save(savePath);
        }
    }
}
