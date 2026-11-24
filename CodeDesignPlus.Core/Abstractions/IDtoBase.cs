using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Abstractions
{
    public interface IDtoBase : IBase  {   }
    public interface IDtoBase<Tkey,TUserKey> : IBase<Tkey,TUserKey>, IDtoBase
    {

    }
}
