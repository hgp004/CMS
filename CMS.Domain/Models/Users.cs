namespace CMS.Demain.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// 后台用户实体
    /// </summary>
    [Serializable]
    public partial class Users
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        public DeleteState IsDelete { get; set; }

        public Guid GUID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public DataState State { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int UserID { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        [CustomStringLength(32, "账号")]
        [StringLength(32)]
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [CustomStringLength(32, "密码")]
        [StringLength(32)]
        public string Pwd { get; set; }
        /// <summary>
        /// 盐值
        /// </summary>
        [CustomStringLength(32, "盐值")]
        [StringLength(32)]
        public string Salt { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [StringLength(16)]
        public string Tel { get; set; }
        [CustomStringLength(64, "真实姓名")]
        [StringLength(64)]
        public string RealName { get; set; }
        public UserType UserType { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
    }
}
