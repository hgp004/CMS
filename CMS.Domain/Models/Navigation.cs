namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// ����ʵ��
    /// </summary>
    public partial class Navigation:DataEntity
    {
        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [StringLength(128)]
        [CustomStringLength(128, "��������")]
        [Display(Name ="��������")]
        public string NavName { get; set; }
        /// <summary>
        /// ��������ID
        /// </summary>
        public Guid? PID { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
        /// <summary>
        /// �����ȼ�
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// ҳ����ʽ
        /// </summary>
        public int? PageStyle { get; set; }
        /// <summary>
        /// ���������
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// һ��������תҳ��
        /// </summary>
        public string OneLVNavUrl { get; set; }
        /// <summary>
        /// ����ģ��������Ƿ�����ҳ��ʾ
        /// </summary>
        public ShowOnIndex ShowOnIndex { get; set; }
    }
}
