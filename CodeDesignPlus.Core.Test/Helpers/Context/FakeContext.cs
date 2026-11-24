using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Test.Helpers.Context
{
    public class FakeContext : DbContext
    {
        protected FakeContext()
        {
        }
        public FakeContext([NotNull] DbContextOptions options) : base(options)
        {
        }
        public DbSet<FakeEntity> FakeEntity { get; set; }
    }
}
