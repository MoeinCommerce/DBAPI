using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Contexts.Interfaces
{
    public interface ICompanyContext
    {
        Dictionary<string, MyCompany> GetAllCompaniesInfo();
        int GetCompaniesCount();
        List<string> GetCompaniesName();
        int GetFiscalYearCount(string companyName);
        Dictionary<string, MyCompany> GetFiscalYears(string companyName);
        (string, MyCompany) GetLastFiscalYear(string companyName);
        List<string> GetMoeinDbNames();
    }
}
