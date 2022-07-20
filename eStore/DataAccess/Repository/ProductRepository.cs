using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public void DeleteProduct(int productID) => ProductDAO.Instance.Remove(productID);

        public Product GetProductByID(int productID) => ProductDAO.Instance.GetProductByID(productID);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpDate(product);
    }
}
