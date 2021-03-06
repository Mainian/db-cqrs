﻿using Microsoft.Extensions.DependencyInjection;

namespace Videa.Data.CQRS.Extensions.Microsoft.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddVideaDatastore(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IDatastoreContext<>), typeof(DatastoreContext<>));

            return serviceCollection;
        }
    }
}
