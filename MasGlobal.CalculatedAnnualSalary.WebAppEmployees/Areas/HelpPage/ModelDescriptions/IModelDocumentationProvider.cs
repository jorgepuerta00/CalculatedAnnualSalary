using System;
using System.Reflection;

namespace MasGlobal.CalculatedAnnualSalary.WebAppEmployees.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}