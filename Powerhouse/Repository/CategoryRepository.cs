using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Powerhouse.Ef;

namespace Powerhouse.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public void Add(Category item)
        {
            dbContext.Categories.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var item = dbContext.Categories.FirstOrDefault(x => x.Id == Id);
            if (item != null)
            {
                dbContext.Categories.Remove(item);
                dbContext.SaveChanges();
            }
        }

        public Category Get(int Id)
        {
            var item = dbContext.Categories.FirstOrDefault(x => x.Id == Id);
            return item;
        }

        public IEnumerable<Category> Get()
        {
            return dbContext.Categories;
        }

        public void Update(Category item)
        {
            var dbItem = dbContext.Categories.FirstOrDefault(x => x.Id == item.Id);
            if (dbItem != null)
            {
                dbItem.Order = item.Order;
                dbItem.Title = item.Title;                
                dbContext.SaveChanges();
            }
        }
    }
}