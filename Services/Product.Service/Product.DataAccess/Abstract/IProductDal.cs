using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Entity.Concrete;

namespace Product.DataAccess.Abstract
{
    public interface IProductDal
    {
        ProductModel Get(int id);

    }
}
