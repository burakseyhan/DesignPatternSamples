using System;

namespace Exercise1.Model
{
    public class ProductModel : BaseModel
    {
        public Int16 UnitsInStock { get; set; }

        public decimal Price { get; set; }
    }
}
