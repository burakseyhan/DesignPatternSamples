using Exercise2.Factory;
using System;
using Exercise2.Enums;
using Exercise2.Interfaces;

namespace DesignPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton Design Pattern Sample
            /*
            IList<ProductModel> repo = ProductRepository.Instance.GetProducts();

            foreach (ProductModel item in repo)
            {
                Console.WriteLine($"Id>> {item.Id}, Name>> {item.Name}, Price>> {item.Price}, UnitsInStock>> {item.UnitsInStock}");
            }
            */
            #endregion


            #region FactoryDesignPattern Sample

            IDocument pdf = BaseFactoryDocument.CreatePdfDocument("Burak Seyhan", "Introduction To C#", 445, DateTime.Now, DocType.Pdf);

            Console.WriteLine($"Authod>> {pdf.Author}, Title>> {pdf.Title}, PageCount>> {pdf.PageCount}, ReleasedDate>> {pdf.ReleasedDate}, DocType>>{pdf.DocType}");

            IDocument word = BaseFactoryDocument.CreateWordDocument("Burak Seyhan", "Async & Await", 234, DateTime.Now, DocType.Word);

            Console.WriteLine($"Authod>> {word.Author}, Title>> {word.Title}, PageCount>> {word.PageCount}, ReleasedDate>> {word.ReleasedDate}, DocType>>{word.DocType}");
            #endregion
            Console.ReadLine();
        }
    }
}
