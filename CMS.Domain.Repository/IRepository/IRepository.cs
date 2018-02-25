using CMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Repository.IRepository
{
    interface IRepository<T> where T:DataEntity
    {

        /// <summary>
        /// 通过主键获取
        /// </summary>
        /// <param name="key">主键ID</param>
        /// <returns>实体对象</returns>
        T GetByKey(Guid key);

    }
}
