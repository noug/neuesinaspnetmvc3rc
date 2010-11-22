using System.Configuration;
using System.Web.Mvc;

namespace NewInMVC3.Extensions
{
    public static class UrlExtensions
    {
        public static string Script(this UrlHelper urlHelper, string scriptPath)
        {
            
#if DEBUG
            scriptPath = scriptPath.Replace(".min.", ".");
#endif
            return urlHelper.Content("~/Scripts/" + scriptPath);
        }
    }
}