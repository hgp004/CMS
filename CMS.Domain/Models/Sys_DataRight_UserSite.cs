namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using System;
    
    /// <summary>
    /// �û�վ������Ȩ��
    /// </summary>
    public partial class Sys_DataRight_UserSite:DataEntity
    {
        /// <summary>
        /// �û�ID
        /// </summary>
        public Guid UserID { get; set; }
        /// <summary>
        /// ���ݱ���
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// ����������ID
        /// </summary>
        public Guid DataID { get; set; }
    }
}
