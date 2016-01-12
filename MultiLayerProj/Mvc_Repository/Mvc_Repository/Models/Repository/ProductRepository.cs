using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc_Repository.Models.Interface;

namespace Mvc_Repository.Models.Repository
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    { 
        /// <summary>
        /// Gets the by ID.
        /// </summary>
        /// <param name="productID">The product ID.</param>
        /// <returns></returns>
        public Products GetByID(int productID)
        {
            return this.Get(x => x.ProductID == productID);
        }

        public IEnumerable<Products> GetByCateogy(int categoryID)
        {
            return this.GetAll().Where(x => x.CategoryID == categoryID);
        }
    }
}