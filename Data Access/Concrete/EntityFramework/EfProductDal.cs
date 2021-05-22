using Data_Access.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1, Name = "AirPods"
                },
                new Product
                {
                    Id = 2, Name = "Mouse"
                }
            };
        }
    }
}
