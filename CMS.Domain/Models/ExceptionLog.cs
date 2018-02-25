namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary>
    /// �쳣��¼
    /// </summary>
    [Table("ExceptionLog")]
    public partial class ExceptionLog : DataEntity
    {
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
        /// <summary>
        /// �����쳣��ʱ��
        /// </summary>
        public DateTime CurrentTime { get; set; }

        /// <summary>
        /// �쳣����
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string Message { get; set; }
    }
}
