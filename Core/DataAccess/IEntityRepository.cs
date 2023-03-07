using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint (kısıt-lama)
    //class : referans tip olabilir demek
    //IEntity : IEntity olabilir ya da IEntity implemet eden bir nesne olabilir
    //new() : new'lenebilir olmalı --- IEntity i kullanmamak için yani boş şablonu kullanmamak için interfaceler new kenemediğinden dolayı koyarız
    //aşağıda bir standart oluşturduk
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Ürünleri kategoriye göre filtrele
        //List<T> GetAllByCategory(int categoryId);
    }
}
