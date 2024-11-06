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
    }
}