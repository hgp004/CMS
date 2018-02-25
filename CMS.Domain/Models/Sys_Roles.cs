namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    

    /// <summary>
    /// 角色实体
    /// </summary>
    public partial class Sys_Roles:DataEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [CustomStringLength(32, "角色名称")]
        [StringLength(32)]
        [Display(Name ="角色名称")]
        public string RoleName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(32)]
        public string Memo { get; set; }
    }
}
