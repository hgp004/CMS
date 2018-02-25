namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    

    /// <summary>
    /// ����ϵͳ��̨����
    /// </summary>
    public partial class Sys_Functions:DataEntity
    {
        /// <summary>
        /// ����ID
        /// </summary>
        [Key]
        public int FuncID { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [StringLength(32)]
        [CustomStringLength(32, "��������")]
        [Display(Name ="��������")]
        public string FuncName { get; set; }
        /// <summary>
        /// ����ĵ�ַ(controler/action)
        /// </summary>
        //[Required]
        //[StringLength(256)]
        public string FuncURL { get; set; }
        /// <summary>
        /// ��������ID
        /// </summary>
        public Guid PID { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        //[Required]
        public FunctionType FuncType { get; set; }
        
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
    }
}
