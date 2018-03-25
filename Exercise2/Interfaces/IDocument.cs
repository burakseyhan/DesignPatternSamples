using Exercise2.Enums;
using System;

namespace Exercise2.Interfaces
{
    public interface IDocument
    {
        string Author { get; set; }

        string Title { get; set; }

        int PageCount { get; set; }

        DateTime ReleasedDate { get; set; }

        DocType DocType { get; set; }
    }
}
