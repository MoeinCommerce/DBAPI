using System;
using System.Collections.Generic;
using DatabaseApi.Contexts.Interfaces;
using DatabaseApi.Exceptions;
using DatabaseApi.Models;

namespace DatabaseApi.Contexts
{
    public abstract class BaseCompanyContext
    {
        protected BaseCompanyContext(Dictionary<string, string> configs)
        {
        }
        public Dictionary<string, Company> GetAllCompaniesInfo()
        {
            throw new System.NotImplementedException();
        }

        public int GetCompaniesCount()
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetCompaniesName()
        {
            throw new System.NotImplementedException();
        }

        public int GetFiscalYearCount(string companyName)
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<string, Company> GetFiscalYears(string companyName)
        {
            throw new System.NotImplementedException();
        }

        public (string, Company) GetLastFiscalYear(string companyName)
        {
            throw new System.NotImplementedException();
        }
    }
}