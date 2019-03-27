using System;
using System.Reflection;

namespace MasGlobal.CalculatedAnnualSalary.wsCalculateAnnualSalary.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}