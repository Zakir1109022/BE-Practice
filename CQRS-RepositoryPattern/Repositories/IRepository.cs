using BE_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Repositories
{
    public interface IRepository<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> GetAll();
        Task<TDocument> GetById(string id);

        Task Create(TDocument document);
        Task<bool> Update(TDocument document);
        Task<bool> Delete(string id);
    }
}
