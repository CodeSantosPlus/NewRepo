using CodeDesignPlus.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Models.Pager
{
    public class Pager<T> where T : IBase
    {
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set;  }
        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set; }
        public int StartIndex { get; private set; }
        public int EndIndex { get; private set; }
        public IEnumerable<int> Pages { get; private set; }
        public List<T> Data { get; private set; }
        public Pager(int totalItems,List<T>data, int currentPage=1,int pageSize=10,int maxPages=10)
        {
            var totalPage = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            if (currentPage < 1)
                currentPage = 1;
            else if (currentPage > totalPage)
                currentPage = totalPage;
            int startPage, endPages;
            if(totalPage<=maxPages)
            {
                startPage = 1;
                endPages = totalPage;
            }else
            {
                var maxPagesBeforeCurrentPage = (int)Math.Floor((decimal)maxPages / (decimal)2);
                var maxPagesAfterCurrentPage = (int)Math.Ceiling((decimal)maxPages / (decimal)2) -1;
                if(currentPage<= maxPagesBeforeCurrentPage)
                {
                    startPage = 1;
                    endPages = maxPages;
                }else if (currentPage + maxPagesAfterCurrentPage >= totalPage)
                {
                    startPage = totalPage - maxPages + 1;
                    endPages = totalPage;
                }else
                {
                    startPage = currentPage - maxPagesBeforeCurrentPage;
                    endPages = currentPage + maxPagesAfterCurrentPage;
                }
            }
            var startIndex = (currentPage - 1) * pageSize;
            var endIndex = Math.Min(startIndex + pageSize - 1, totalItems - 1);
            var pages = Enumerable.Range(startPage, (endPages + 1) - startPage);
            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.StartPage = startPage;
            this.EndPage = endPages;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Pages = pages;
            this.Data = data;
            this.TotalPages = totalPage;

        }

    }
}
