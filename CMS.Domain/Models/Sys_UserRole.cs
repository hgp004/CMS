namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    

    /// <summary>
    /// 用户角色
    /// </summary>
    public partial class Sys_UserRole:DataEntity
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [StringLength(32)]
        [Display(Name ="角色名称")]
        [CustomStringLength(32, "角色名称")]

        public string RoleName { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserID { get; set; }
    }
}
