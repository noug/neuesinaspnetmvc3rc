using System.Web;
using System.Web.Mvc;

namespace NewInMVC3
{
    public static class HtmlExtensions
    {
        public static IHtmlString HtmlDecode(this HtmlHelper htmlHelper, string text)
        {
            return new HtmlString(text);
        }
    }
}