using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Abstractions
{
    public interface IBase { }

    public interface IBase<TKey,TUserKey>:IBase
    {
        public TKey Id { get; set;}
        public bool State { get; set; }
        public TUserKey IdUserCreator { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
