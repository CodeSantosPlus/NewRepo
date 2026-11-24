using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Abstractions
{
    public interface IStartupServices
    {
        void Initialize(IServiceCollection servuces, IConfiguration configuration);
    }
}
