using NewInMVC3.Services;

namespace NewInMVC3.Views
{
    public abstract class NewWebViewPage : System.Web.Mvc.WebViewPage
    {
        public ISimpleService SimpleService { get; set; }
    }

    public abstract class NewWebViewPage<T> : System.Web.Mvc.WebViewPage<T>
    {
        public ISimpleService SimpleService { get; set; }
    }
}