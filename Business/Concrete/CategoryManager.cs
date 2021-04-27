using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL (Category entity)
        {
            if(entity.CategoryName=="" || entity.CategoryName.Length <=3 ||
                entity.CategoryDescription=="" || entity.CategoryName.Length >= 51)
            {
                //error message
            }
            else
            {
                repo.Insert(entity);
            }
        }    
    }

}
