using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface ITableManager
    {
        void CreateTable(string name, List<string> columnInfo);
        void DeleteTable(string name);
        void CreateTrigger(string triggerName, string triggerSql);
    }
}
