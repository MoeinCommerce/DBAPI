using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface ICompanyRepository
    {
        Dictionary<string, MyCompany> GetAllCompaniesInfo();
        int GetCompaniesCount();
        List<string> GetCompaniesName();
        int GetFiscalYearCount(string companyName);
        List<MyCompany> GetFiscalYears(string companyName);
        MyCompany GetLastFiscalYear(string companyName);
        List<string> GetMoeinDbNames();
    }
}
