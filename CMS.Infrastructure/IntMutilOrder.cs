using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure
{
    /// <summary>
    /// 多字段排序
    /// </summary>
    public class IntMutilOrder: IComparable
    {
        public int FristColumn { get; set; }
        public int SecondColumn { get; set; }
        /// <summary>
        /// 是否倒序
        /// </summary>
        public bool IsDesc { get; set; }

        public int CompareTo(object obj)
        {
            int reuslt = 0;
            try
            {
                IntMutilOrder other = (IntMutilOrder)obj;
                if (this.FristColumn > other.FristColumn)
                {
                    reuslt = 1;
                }
                if (this.FristColumn == other.FristColumn)
                {
                    if (this.SecondColumn == other.SecondColumn)
                    {
                        reuslt = 0;
                    }
                    if (this.SecondColumn < other.SecondColumn)
                    {
                        reuslt = -1;
                    }
                    else
                    {
                        reuslt = 1;
                    }
                }
                if (this.FristColumn < other.FristColumn)
                {
                    reuslt = -1;
                }
            }
            catch (Exception)
            {
                reuslt = -1;
            }
            if (IsDesc)
            {
                reuslt = reuslt * -1;
            }
            return reuslt;
        }
        //public override bool Equals(object obj)
        //{
        //    try
        //    {
        //        IntMutilOrder other = (IntMutilOrder)obj;
        //        if (this.FristColumn > other.FristColumn)
        //        {
        //            return true;
        //        }
        //        if (this.FristColumn == other.FristColumn)
        //        {
        //            if(this.SecondColumn)
        //        }
        //    }
        //    catch {
        //        return false;
        //    }
        //}
    }
}
