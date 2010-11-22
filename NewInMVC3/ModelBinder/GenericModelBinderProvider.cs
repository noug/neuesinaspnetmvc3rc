using System;
using System.Web.Mvc;

namespace NewInMVC3.ModelBinder
{
    public class  GenericModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(Type modelType)
        {
            var genericType = typeof (IModelBinder<>).MakeGenericType(modelType);
            return (IModelBinder) DependencyResolver.Current.GetService(genericType);
        } 
    }
}