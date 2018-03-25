using Exercise2.Enums;
using Exercise2.Interfaces;

using System;

namespace Exercise2.Factory
{
    public class BaseFactoryDocument
    {
        public static IDocument CreateWordDocument(string Author, string Title, int PageCount, DateTime ReleasedDate, DocType DocType)
        {
            return new WordDocumentFactory(Author, Title, PageCount, ReleasedDate, DocType);
        }

        public static IDocument CreatePdfDocument(string Author, string Title, int PageCount, DateTime ReleasedDate, DocType DocType)
        {
            return new PdfDocumentFactory(Author, Title, PageCount, ReleasedDate, DocType);
        }
    }
}
