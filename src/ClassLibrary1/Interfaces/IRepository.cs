using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T>where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);//idye göre getir. 
        Task<List<T>> GetAllAsync(); 
        Task<List<T>> GetAllAsync(ISpecification<T>specification);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);//void ;verilen veriyi update etsin. 
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> specification);//ürünlerden kategorisi şu olan kaç tane var buna bakalım.
        Task<T> FirstAsync(ISpecification<T> specification);//şartlara uyan ilk elemanı getir.
        Task<T> FirstorDefaultAsync(ISpecification<T> specification);



    }
}
