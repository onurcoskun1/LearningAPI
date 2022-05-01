using KodluyoruzTest.DataAccess.Repositories;
using KodluyoruzTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzTest.Business
{
    public class ProductService
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
