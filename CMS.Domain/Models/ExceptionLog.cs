namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary>
    /// 异常记录
    /// </summary>
    [Table("ExceptionLog")]
    public partial class ExceptionLog : DataEntity
    {
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
        /// <summary>
        /// 发生异常的时间
        /// </summary>
        public DateTime CurrentTime { get; set; }

        /// <summary>
        /// 异常级别
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; set; }
    }
}
