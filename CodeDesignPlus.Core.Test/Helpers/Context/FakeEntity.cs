using CodeDesignPlus.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Test.Helpers.Context
{
    public class FakeEntity : IEntityLong<string>
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool State { get; set; }
        public string IdUserCreator { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
       
    }
}
