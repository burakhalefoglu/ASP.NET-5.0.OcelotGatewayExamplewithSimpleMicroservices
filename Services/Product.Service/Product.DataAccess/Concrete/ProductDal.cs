using Product.DataAccess.Abstract;
using Product.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
        public ProductModel Get(int id)
        {
            if (id == 1)
            {
                return new ProductModel
                {
                    Id = 1,
                    Name = "bilgisayar",
                    Price = 10000
                };
            }

            return new ProductModel
            {
                Id = 0,
                Name = "",
                Price = 0
            };

        }
    }
}
