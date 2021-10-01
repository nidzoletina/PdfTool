namespace PdfTool.Tools
{
    internal static partial class PdfTools
    {
        public static string Help { 
            get
            {
                return @"
Usage examples:
===============

Removing page from file:

        .\PdfTool.exe <targetFilePath> --removePage <targetPageNumber>


Joining 2 documents:

        .\PdfTool.exe <documentToJoinToPath> --joinWith <documentToJoinPath>


Extracting pages from document:

        .\PdfTool.exe <documentToExtractPageFrom> --extactPages <extractionStartingPage> <lastPageToExtract>

";
            }
        }
    }
}