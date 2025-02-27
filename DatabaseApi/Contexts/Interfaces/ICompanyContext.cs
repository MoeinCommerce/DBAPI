// DatabaseApi
using DatabaseApi.Models;

// System
using System.Collections.Generic;


namespace DatabaseApi.Contexts.Interfaces
{
    public interface ICompanyContext
    {
        /// <summary>
        /// Retrieves information for all companies.
        /// </summary>
        /// <returns>
        /// A dictionary where each key is a company name, and the value is the corresponding <see cref="Company"/>
        /// object containing the company's details.
        /// </returns>
        Dictionary<string, Company> GetAllCompaniesInfo();

        /// <summary>
        /// Retrieves the total number of companies.
        /// </summary>
        /// <returns>
        /// The count of companies in the database.
        /// </returns>
        int GetCompaniesCount();

        /// <summary>
        /// Retrieves the names of all companies.
        /// </summary>
        /// <returns>
        /// A list of all company names.
        /// </returns>
        List<string> GetCompaniesName();

        /// <summary>
        /// Retrieves the count of fiscal years available for a specified company.
        /// </summary>
        /// <param name="companyName">
        /// The name of the company for which to retrieve the fiscal year count.
        /// </param>
        /// <returns>
        /// The number of fiscal years associated with the specified company.
        /// </returns>
        int GetFiscalYearCount(string companyName);

        /// <summary>
        /// Retrieves the most recent fiscal year and its data for a specified company.
        /// </summary>
        /// <param name="companyName">
        /// The name of the company for which to retrieve the last fiscal year data.
        /// </param>
        /// <returns>
        /// A tuple containing the last fiscal year's identifier as a string and the <see cref="Company"/>
        /// object with data for that fiscal year.
        /// </returns>
        (string, Company) GetLastFiscalYear(string companyName);
    }
}
