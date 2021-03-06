﻿using System;
using Videa.Data.CQRS.Provider;

namespace Videa.Data.CQRS
{
    public abstract class BaseDataService<T> : IDisposable
        where T : IDbProvider
    {
        protected IDatastoreContext<T> DatastoreContext { get; private set; }

        protected BaseDataService(IDatastoreContext<T> datastoreContext)
        {
            DatastoreContext = datastoreContext ?? throw new ArgumentNullException(nameof(datastoreContext));
        }

        public virtual void Dispose()
        {
            if (DatastoreContext != null)
            {
                DatastoreContext.Dispose();
                DatastoreContext = null;
            }
        }
    }
}