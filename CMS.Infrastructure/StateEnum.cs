using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure
{
    /// <summary>
    /// 数据启用禁用状态
    /// </summary>
    public enum DataState
    {
        /// <summary>
        /// 启用状态
        /// </summary>
        ON=0,
        /// <summary>
        /// 禁用状态
        /// </summary>
        OFF=1
    }
    /// <summary>
    /// 数据删除状态
    /// </summary>
    public enum DeleteState
    {
        /// <summary>
        /// 数据未删除状态
        /// </summary>
        UnDelete=0,
        /// <summary>
        /// 数据删除状态
        /// </summary>
        Deleted=1
    }
}
