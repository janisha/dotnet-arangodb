﻿using System.Threading;
using System.Threading.Tasks;
using Core.Arango.Protocol;
using Newtonsoft.Json.Linq;

namespace Core.Arango.Modules
{
    public interface IArangoTransactionModule
    {
        Task AbortAsync(ArangoHandle database, CancellationToken cancellationToken = default);

        Task<ArangoHandle> BeginAsync(ArangoHandle database, ArangoTransaction request,
            CancellationToken cancellationToken = default);

        Task CommitAsync(ArangoHandle database, CancellationToken cancellationToken = default);

        Task<T> ExecuteAsync<T>(ArangoHandle database, ArangoTransaction request,
            CancellationToken cancellationToken = default);
    }
}