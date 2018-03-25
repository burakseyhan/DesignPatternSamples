using Exercise1.Model;

using System.Collections.Generic;

namespace Exercise1
{
    public sealed class ProductRepository
    {
        private static ProductRepository productRepository = null;
        private ProductRepository()
        {

        }

        public static ProductRepository Instance
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository();
                }

                return productRepository;
            }
        }

        public IList<ProductModel> GetProducts()
        {
            IList<ProductModel> modelList = new List<ProductModel>();

            modelList.Add(new ProductModel() { Id = 1, Name = "Computer", Price = 10.7M, UnitsInStock = 100 });
            modelList.Add(new ProductModel() { Id = 1, Name = "Computer1", Price = 9.7M, UnitsInStock = 120 });
            modelList.Add(new ProductModel() { Id = 1, Name = "Computer2", Price = 150.7M, UnitsInStock = 150 });
            modelList.Add(new ProductModel() { Id = 1, Name = "Computer3", Price = 102.7M, UnitsInStock = 170 });
            modelList.Add(new ProductModel() { Id = 1, Name = "Computer4", Price = 105.7M, UnitsInStock = 190 });
            modelList.Add(new ProductModel() { Id = 1, Name = "Computer5", Price = 100.7M, UnitsInStock = 200 });
            modelList.Add(new ProductModel() { Id = 1, Name = "Computer6", Price = 8.7M, UnitsInStock = 400 });

            return modelList;
        }
    }
}
