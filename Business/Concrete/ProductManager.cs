using Business.Abstract;
using Core.Aspects.Logging;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Data_Access.Abstract;
using Data_Access.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // Dependency Injection

        private IProductDal _productDal;
        private ILogger _logger;
        private ICache _cache;

        public ProductManager(EfProductDal efProductDal)
        {
            _productDal = efProductDal;
        }

        [LogAspect]
        public List<Product> GetAll()
        {
            // business codes

            //_logger.Log();
            //_cache.Cache();
            return _productDal.GetAll();
        }
    }
}
