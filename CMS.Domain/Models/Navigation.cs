namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 导航实体
    /// </summary>
    public partial class Navigation:DataEntity
    {
        /// <summary>
        /// 导航名称
        /// </summary>
        [Required]
        [StringLength(128)]
        [CustomStringLength(128, "导航名称")]
        [Display(Name ="导航名称")]
        public string NavName { get; set; }
        /// <summary>
        /// 父级导航ID
        /// </summary>
        public Guid? PID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
        /// <summary>
        /// 导航等级
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 页面样式
        /// </summary>
        public int? PageStyle { get; set; }
        /// <summary>
        /// 版块内索引
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 一级导航跳转页面
        /// </summary>
        public string OneLVNavUrl { get; set; }
        /// <summary>
        /// 导航模块的数据是否在首页显示
        /// </summary>
        public ShowOnIndex ShowOnIndex { get; set; }
    }
}
