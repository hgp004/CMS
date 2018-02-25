namespace CMS.Demain.Models
{
    using CMS.Domain.Models;
    using System;
    
    /// <summary>
    /// 用户站点数据权限
    /// </summary>
    public partial class Sys_DataRight_UserSite:DataEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserID { get; set; }
        /// <summary>
        /// 数据表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 关联的数据ID
        /// </summary>
        public Guid DataID { get; set; }
    }
}
