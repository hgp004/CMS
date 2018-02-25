using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure
{
    public class PagedQueryParam
    {
        private int count;

        private bool desc;

        private int index;

        private string orderColumn;

        private int size;

        private int skip;

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public bool Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
        }

        public int Index
        {
            get { return this.index > 0 ? this.index : 1; }
            set { this.index = value > 0 ? value : 1; }
        }

        public string OrderColumn
        {
            get { return this.orderColumn; }
            set { this.orderColumn = value; }
        }

        public int Size
        {
            get { return this.size > 0 ? this.size : 15; }
            set { this.size = value > 0 ? value : 15; }
        }

        public int Skip
        {
            get { return this.skip; }
        }

        public PagedQueryParam()
            : this(1, 15)
        { }

        public PagedQueryParam(int index, int size)
        {
            this.count = 0;
            this.desc = false;
            this.index = index > 0 ? index : 1;
            this.orderColumn = string.Empty;
            this.size = size > 0 ? size : 15;
            this.skip = (this.index - 1) * this.size;
        }
    }
}
