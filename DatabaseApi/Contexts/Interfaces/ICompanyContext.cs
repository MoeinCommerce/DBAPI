using System.Collections.Generic;
using DatabaseApi.Models;

namespace DatabaseApi.Contexts.Interfaces
{
    public interface ICompanyContext
    {
        Dictionary<string, Company> GetAllCompaniesInfo();
        int GetCompaniesCount();
        List<string> GetCompaniesName();
        int GetFiscalYearCount(string companyName);
        Dictionary<string, Company> GetFiscalYears(string companyName);
        (string, Company) GetLastFiscalYear(string companyName);
        List<string> GetMoeinDbNames();
    }
}
