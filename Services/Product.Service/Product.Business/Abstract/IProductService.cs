using Product.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Abstract
{
    public interface IProductService
    {
        ProductModel GetProduct(int id);
    }
}
