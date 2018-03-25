using Exercise2.Enums;
using Exercise2.Interfaces;
using System;

namespace Exercise2.Factory
{
    public class WordDocumentFactory : IDocument
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DocType DocType { get; set; }

        public WordDocumentFactory(string Author, string Title, int PageCount, DateTime ReleasedDate, DocType docType)
        {
            this.Author = Author;
            this.Title = Title;
            this.PageCount = PageCount;
            this.ReleasedDate = ReleasedDate;
            this.DocType = DocType.Word;
        }
    }
}
