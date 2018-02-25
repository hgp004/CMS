namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    

    /// <summary>
    /// 管理系统后台功能
    /// </summary>
    public partial class Sys_Functions:DataEntity
    {
        /// <summary>
        /// 功能ID
        /// </summary>
        [Key]
        public int FuncID { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        [Required]
        [StringLength(32)]
        [CustomStringLength(32, "功能名称")]
        [Display(Name ="功能名称")]
        public string FuncName { get; set; }
        /// <summary>
        /// 请求的地址(controler/action)
        /// </summary>
        //[Required]
        //[StringLength(256)]
        public string FuncURL { get; set; }
        /// <summary>
        /// 父级功能ID
        /// </summary>
        public Guid PID { get; set; }
        /// <summary>
        /// 功能类型
        /// </summary>
        //[Required]
        public FunctionType FuncType { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
    }
}
