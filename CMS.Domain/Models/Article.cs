namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 文章实体
    /// </summary>
    public partial class Article:DataEntity
    {
        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        [CustomStringLength(128, "标题")]
        [StringLength(128,ErrorMessage ="最多64个汉字或者128个英文字符")]
        [Display(Name = "标题")]
        public string Title { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime ReleaseTime { get; set; }

        /// <summary>
        /// 排列顺序
        /// </summary>
        public int OrderIndex { get; set; }
        /// 文章状态
        /// </summary>
        public DataState ArticleStatus { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [Required]
        //[StringLength(2048)]
        [Display(Name = "详情")]
        public string ArticleDetail { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [Required]
        //[StringLength(512)]
        [Display(Name ="简介")]
        public string Synopsis { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(32)]
        public string Memo { get; set; }
        /// <summary>
        /// 缩略图地址
        /// </summary>
        //[StringLength(256)]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// 导航ID
        /// </summary>
        public Guid NavID { get; set; }

        /// <summary>
        /// 文章信息来源
        /// </summary>
        [StringLength(128)]
        public string Source { get; set; }
        /// <summary>
        /// 附件地址
        /// </summary>
        public string Appendix { get; set; }
        public int ClickAmount { get; set; }
    }

}
