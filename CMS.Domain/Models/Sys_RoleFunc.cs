namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections;
    using System.Collections.Generic;


    /// <summary>
    /// 角色功能表
    /// </summary>
    public partial class Sys_RoleFunc:DataEntity
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [CustomStringLength(32, "角色名称")]
        [StringLength(32)]
        public string RoleName { get; set; }
        /// <summary>
        /// 功能ID
        /// </summary>
        public Guid FuncID { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        [CustomStringLength(32, "功能名称")]
        [StringLength(32)]
        public string FuncName { get; set; }

        public IEnumerable<Sys_Functions> Sys_Functions { get; set; }
    }
}
