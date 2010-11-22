using System;
using System.Web;

namespace NewInMVC3.Services
{
    public interface ISimpleService
    {
        string What();
        IHtmlString WhatElse();
    }
}