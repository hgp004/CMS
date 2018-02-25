namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// ����ʵ��
    /// </summary>
    public partial class Article:DataEntity
    {
        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [CustomStringLength(128, "����")]
        [StringLength(128,ErrorMessage ="���64�����ֻ���128��Ӣ���ַ�")]
        [Display(Name = "����")]
        public string Title { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime ReleaseTime { get; set; }

        /// <summary>
        /// ����˳��
        /// </summary>
        public int OrderIndex { get; set; }
        /// ����״̬
        /// </summary>
        public DataState ArticleStatus { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        //[StringLength(2048)]
        [Display(Name = "����")]
        public string ArticleDetail { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        [Required]
        //[StringLength(512)]
        [Display(Name ="���")]
        public string Synopsis { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(32)]
        public string Memo { get; set; }
        /// <summary>
        /// ����ͼ��ַ
        /// </summary>
        //[StringLength(256)]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        public Guid NavID { get; set; }

        /// <summary>
        /// ������Ϣ��Դ
        /// </summary>
        [StringLength(128)]
        public string Source { get; set; }
        /// <summary>
        /// ������ַ
        /// </summary>
        public string Appendix { get; set; }
        public int ClickAmount { get; set; }
    }

}
