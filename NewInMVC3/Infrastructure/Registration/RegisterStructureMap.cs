using System.Web.Mvc;

namespace NewInMVC3.Infrastructure.Registration
{
    internal static class RegisterStructureMap
    {
        public static void Execute()
        {
            var container = new StructureMap.Container();

            container.Configure(c =>
                                    {
                                        c.Scan(x =>
                                                   {
                                                       x.AssembliesFromApplicationBaseDirectory();
                                                       x.WithDefaultConventions();
                                                       x.LookForRegistries();
                                                   });
                                        c.SetAllProperties(x =>
                                                           x.TypeMatches(
                                                               type => container.Model.HasImplementationsFor(type)));
                                    });

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
            FilterProviders.Providers.Add(new StructureMapFilterAttributeFilterProvider(container));
        }
    }
}