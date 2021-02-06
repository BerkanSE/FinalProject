using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{


    public interface ICategoryDal:IEntityRepository<Category> //Public önemlidir.Diğer katmanlardan erişimi sağlar (referans verdiğimiz zaman)
    {
        //Generic altyapı
        //List<Category> GetAll();
        //void Add(Category category);
        //void Update(Category category);
        //void Delete(Category category);

        //List<Category> GetAllByCategory(int categoryId);
    }
}
