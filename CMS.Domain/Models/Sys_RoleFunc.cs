namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using CMS.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections;
    using System.Collections.Generic;


    /// <summary>
    /// ��ɫ���ܱ�
    /// </summary>
    public partial class Sys_RoleFunc:DataEntity
    {
        /// <summary>
        /// ��ɫID
        /// </summary>
        public Guid RoleID { get; set; }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        [CustomStringLength(32, "��ɫ����")]
        [StringLength(32)]
        public string RoleName { get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        public Guid FuncID { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [CustomStringLength(32, "��������")]
        [StringLength(32)]
        public string FuncName { get; set; }

        public IEnumerable<Sys_Functions> Sys_Functions { get; set; }
    }
}
