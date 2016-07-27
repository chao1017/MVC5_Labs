﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc_Repository.Models.Interface;

namespace Mvc_Repository.Models.Repository
{
    public class CategoryRepository : GenericRepository<Categories>, ICategoryRepository
    {
        /// <summary>
        /// Gets the by ID.
        /// </summary>
        /// <param name="categoryID">The category ID.</param>
        /// <returns></returns>
        public Categories GetByID(int categoryID)
        {
            return this.Get(x => x.CategoryID == categoryID);
        }
    }
}