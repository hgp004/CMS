namespace CMS.Demain.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// ��̨�û�ʵ��
    /// </summary>
    [Serializable]
    public partial class Users
    {
        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        public DeleteState IsDelete { get; set; }

        public Guid GUID { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(128)]
        public string Memo { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public DataState State { get; set; }

        /// <summary>
        /// �û�ID
        /// </summary>
        [Key]
        public int UserID { get; set; }
        /// <summary>
        /// ��¼�˺�
        /// </summary>
        [CustomStringLength(32, "�˺�")]
        [StringLength(32)]
        public string Account { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [CustomStringLength(32, "����")]
        [StringLength(32)]
        public string Pwd { get; set; }
        /// <summary>
        /// ��ֵ
        /// </summary>
        [CustomStringLength(32, "��ֵ")]
        [StringLength(32)]
        public string Salt { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        [StringLength(16)]
        public string Tel { get; set; }
        [CustomStringLength(64, "��ʵ����")]
        [StringLength(64)]
        public string RealName { get; set; }
        public UserType UserType { get; set; }
        /// <summary>
        /// �ϴε�¼ʱ��
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
    }
}
