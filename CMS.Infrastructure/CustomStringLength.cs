using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMS.Infrastructure
{
    public class CustomStringLength : ValidationAttribute
    {
        //
        // 摘要:
        //     获取或设置字符串的最大长度。
        //
        // 返回结果:
        //     字符串的最大长度。
        public int MaximumLength { get; }
        //
        // 摘要:
        //     获取或设置字符串的最小长度。
        //
        // 返回结果:
        //     字符串的最小长度。
        public int MinimumLength { get; set; }
        public string Name { get; set; }
        public CustomStringLength(int maxLen, string name)
        {
            this.MaximumLength = maxLen;
            this.Name = name;
        }
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var v = value.ToString();
                var snew = Regex.Replace(v, @"[\u4e00-\u9fa5]", "aa");
                //值本身就超过了定义的长度的用。stringlenth校验，这里不错校验避免重复
                if (snew.ToString().Length > MaximumLength && v.Length < MaximumLength)
                {
                    this.ErrorMessage = string.Format(@"‘{0}’长度不能超过{1}个中文字符或者{2}个英文字符", this.Name, MaximumLength / 2, MaximumLength);
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
