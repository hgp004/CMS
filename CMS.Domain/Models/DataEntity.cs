using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Infrastructure;

namespace CMS.Domain.Models
{
    /// <summary>
    /// 数据实体基类
    /// </summary>
    public class DataEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid GUID { get; set; }
        /// <summary>
        /// 自增索引
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 启用禁用
        /// </summary>
        public DataState State { get; set; }
        /// <summary>
        /// 逻辑删除状态
        /// </summary>
        public DeleteState DeleteState { get; set; }
    }
}
