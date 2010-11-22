using System;
using System.Web.Mvc;
using NewInMVC3.Services;

namespace NewInMVC3.ActionFilter
{
    public class DIActionAttribute : FilterAttribute, IActionFilter
    {
        public ISimpleService Service { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Service.What();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
    }
}