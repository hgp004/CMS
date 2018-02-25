namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    

    /// <summary>
    /// �û���ɫ
    /// </summary>
    public partial class Sys_UserRole:DataEntity
    {
        /// <summary>
        /// ��ɫID
        /// </summary>
        public Guid RoleID { get; set; }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        [Required]
        [StringLength(32)]
        [Display(Name ="��ɫ����")]
        [CustomStringLength(32, "��ɫ����")]

        public string RoleName { get; set; }
        /// <summary>
        /// �û�ID
        /// </summary>
        public Guid UserID { get; set; }
    }
}
