using System.Web;

namespace NewInMVC3.Services
{
    public class SimpleService : ISimpleService {
        public string What()
        {
            return "<i>Das ist doch mal was</i>";
        }


        public IHtmlString WhatElse()
        {
            return new HtmlString(What());
        }

    }
}