using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetProductList()
        {
            var product = new List<Product>();
            try
            {
                using var context = new Ass2PRNContext();
                product = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;

        }

        public Product GetProductByID(int productID)
        {
            Product product = null;
            try
            {
                using var context = new Ass2PRNContext();
                product = context.Products.SingleOrDefault(p => p.ProductId == productID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void AddProduct(Product product)
        {
            try
            {
                Product product1 = GetProductByID(product.ProductId);
                if (product1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Product is already exist");
            }
        }

        public void UpDate(Product product)
        {
            try
            {
                Product product1 = GetProductByID(product.ProductId);
                if (product1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int productID)
        {
            try
            {
                Product product = GetProductByID(productID);
                if (product != null)
                {
                    using var context = new Ass2PRNContext();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
