namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    

    /// <summary>
    /// ��ɫʵ��
    /// </summary>
    public partial class Sys_Roles:DataEntity
    {
        /// <summary>
        /// ��ɫ����
        /// </summary>
        [Required]
        [CustomStringLength(32, "��ɫ����")]
        [StringLength(32)]
        [Display(Name ="��ɫ����")]
        public string RoleName { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(32)]
        public string Memo { get; set; }
    }
}
