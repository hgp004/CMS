using System;
using System.ComponentModel.DataAnnotations;

using System.Collections.Generic;
using CMS.Infrastructure;
using CMS.Domain.Models;

namespace CMS.Demain.Models
{
    public class Sys_NumberCfg:DataEntity
    {
        /// <summary>
        /// 编号类型
        /// </summary>
        [CustomStringLength(32, "编号类型")]
        [StringLength(32)]
        public string NumberType { get; set; }
        /// <summary>
        /// 当前序号
        /// </summary>
        public int CurrentNum { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
    }
}
