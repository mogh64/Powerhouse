using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Powerhouse.Ef;

namespace Powerhouse.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SubjectRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Subject item)
        {
            dbContext.Subjects.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var item = dbContext.Subjects.FirstOrDefault(x => x.Id == Id);
            if (item != null)
            {
                dbContext.Subjects.Remove(item);
                dbContext.SaveChanges();
            }
        }

        public Subject Get(int Id)
        {
            var item = dbContext.Subjects.FirstOrDefault(x => x.Id == Id);
            return item;
        }

        public IEnumerable<Subject> Get()
        {
            return dbContext.Subjects;
        }

        public void Update(Subject item)
        {
            var dbItem = dbContext.Subjects.FirstOrDefault(x => x.Id == item.Id);
            if (dbItem != null)
            {
                dbItem.Order = item.Order;
                dbItem.Title = item.Title;
                dbItem.Url = item.Url;
                dbItem.CategoryId = item.CategoryId;
                
                dbContext.SaveChanges();
            }
        }
    }
}