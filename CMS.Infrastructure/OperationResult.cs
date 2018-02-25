using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure
{
    /// <summary>
    /// 业务操作结果类
    /// </summary>
    public class OperationResult
    {
        public OperationResult()
        {
            this.IsSuccess = false;
            this.Message = "";
        }
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 具体消息
        /// </summary>
        public string Message { get; set; }
    }
}
