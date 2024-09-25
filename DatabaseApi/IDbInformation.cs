using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi
{
    public interface IDbInformation
    {
        string Name { get; }
        string DisplayName { get; }
        string Description { get; }
        string ExecutablePath { get; }
        string Version { get; }
        Dictionary<string, string> Configurations { get; }
    }
}
