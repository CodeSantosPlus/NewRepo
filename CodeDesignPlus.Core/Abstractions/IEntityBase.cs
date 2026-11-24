using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Abstractions
{
    public interface IEntityBase : IBase { }
    public interface IEntityBase<TKey,TUserKey> : IBase<TKey,TUserKey>, IEntityBase
    {

    }
}
