using NewInMVC3.ModelBinder;
using StructureMap.Configuration.DSL;

namespace NewInMVC3.Registration
{
    public class ProjectSpecificRegistry : Registry
    {
        public ProjectSpecificRegistry()
        {
            Scan(x =>
                     {
                         x.AssembliesFromApplicationBaseDirectory();
                         x.ConnectImplementationsToTypesClosing(typeof (IModelBinder<>));
                     });
        }
    }
}