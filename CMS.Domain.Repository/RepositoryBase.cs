using CMS.Domain.Models;
using CMS.Domain.Repository.EntityForameWork;
using CMS.Domain.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : DataEntity
    {
        private CMSContext _context;
        public RepositoryBase(CMSContext context)
        {
            this._context = context;
        }
        public T GetByKey(Guid key)
        {
            var dbset = _context.Set<T>();
            return dbset.Find(key);
        }
    }
}
