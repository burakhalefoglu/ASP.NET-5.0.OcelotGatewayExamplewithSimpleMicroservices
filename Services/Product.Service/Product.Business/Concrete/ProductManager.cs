using Product.Business.Abstract;
using Product.DataAccess.Abstract;
using Product.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public ProductModel GetProduct(int id)
        {
            return _ProductDal.Get(id);
        }
    }
}
