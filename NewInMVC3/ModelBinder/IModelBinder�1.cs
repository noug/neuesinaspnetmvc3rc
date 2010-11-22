using System.Web.Mvc;

namespace NewInMVC3.ModelBinder
{
    public interface IModelBinder<T> : IModelBinder where T : class {}
}