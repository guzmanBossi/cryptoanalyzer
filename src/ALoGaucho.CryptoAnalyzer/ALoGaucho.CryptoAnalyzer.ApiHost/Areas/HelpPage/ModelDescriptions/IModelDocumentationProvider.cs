using System;
using System.Reflection;

namespace ALoGaucho.CryptoAnalyzer.ApiHost.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}