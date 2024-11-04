using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseApi.Contexts.Interfaces;
using DatabaseApi.Models;

namespace DatabaseApi.Contexts
{
    public abstract class BaseDatabaseContext
    {
        #region Fields

        protected Dictionary<string, string> Configs;

        #endregion

        #region Constructors

        protected BaseDatabaseContext(Dictionary<string, string> configs)
        {
            Configs = configs;
        }

        #endregion
    }
}