using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Models.Pager
{
    public class Parameters
    {
        [Range(1,int.MaxValue,ErrorMessage ="The {0} field not is valid")]
        public int CurrentPage { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="The {0} field not is valid")]
        public int PageSize { get; set; }
        [Range(0,int.MaxValue,ErrorMessage ="The {0} field not is valid")]
        public int MaxPage { get; set; }

    }
}
