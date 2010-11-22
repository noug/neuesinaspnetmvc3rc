using System.Web.Mvc;
using NewInMVC3.Models;

namespace NewInMVC3.ModelBinder
{
    public class PersonModelBinder : IModelBinder<Person>
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new Person();
        }
    }
}