﻿using Core.Arango.Protocol;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Arango.Modules
{
    public interface IArangoDocumentModule
    {
        Task CreateAsync<T>(ArangoHandle database, string collection, IEnumerable<T> docs, bool waitForSync = false, bool silent = true, bool overwrite = false, CancellationToken cancellationToken = default) where T : class;
        Task<T> CreateAsync<T>(ArangoHandle database, string collection, T doc, bool waitForSync = false, bool silent = true, bool overwrite = false, CancellationToken cancellationToken = default) where T : class;
        Task<List<ArangoUpdateResult<TR>>> DeleteAsync<T, TR>(ArangoHandle database, string collection, IEnumerable<T> docs, bool? waitForSync = null, bool? returnOld = null, CancellationToken cancellationToken = default) where T : class;
        Task<ArangoUpdateResult<TR>> DeleteAsync<TR>(ArangoHandle database, string collection, string key, bool? waitForSync = null, bool? returnOld = null, bool? silent = null, CancellationToken cancellationToken = default);
        Task ImportAsync<T>(ArangoHandle database, string collection, IEnumerable<T> docs, bool complete = true, CancellationToken cancellationToken = default) where T : class;
        Task<List<ArangoUpdateResult<TR>>> ReplaceAsync<T, TR>(ArangoHandle database, string collection, IEnumerable<T> docs, bool? waitForSync = null, bool? returnOld = null, bool? returnNew = null, CancellationToken cancellationToken = default) where T : class;
        Task<List<ArangoUpdateResult<JObject>>> ReplaceAsync<T>(ArangoHandle database, string collection, IEnumerable<T> docs, bool? waitForSync = null, bool? returnOld = null, bool? returnNew = null, CancellationToken cancellationToken = default) where T : class;
        Task<ArangoUpdateResult<TR>> ReplaceAsync<T, TR>(ArangoHandle database, string collection, T doc, bool waitForSync = false, bool? returnOld = null, bool? returnNew = null, CancellationToken cancellationToken = default) where T : class;
        Task<ArangoUpdateResult<JObject>> ReplaceAsync<T>(ArangoHandle database, string collection, T doc, bool waitForSync = false, bool? returnOld = null, bool? returnNew = null, CancellationToken cancellationToken = default) where T : class;
        Task<List<ArangoUpdateResult<JObject>>> UpdateAsync<T>(ArangoHandle database, string collection, IEnumerable<T> docs, bool? waitForSync = null, bool? keepNull = null, bool? mergeObjects = null, bool? returnOld = null, bool? returnNew = null, bool? silent = null, CancellationToken cancellationToken = default) where T : class;
        Task<List<ArangoUpdateResult<TR>>> UpdateAsync<T, TR>(ArangoHandle database, string collection, IEnumerable<T> docs, bool? waitForSync = null, bool? keepNull = null, bool? mergeObjects = null, bool? returnOld = null, bool? returnNew = null, bool? silent = null, CancellationToken cancellationToken = default) where T : class;
        Task<ArangoUpdateResult<JObject>> UpdateAsync<T>(ArangoHandle database, string collection, T doc, bool? waitForSync = null, bool? keepNull = null, bool? mergeObjects = null, bool? returnOld = null, bool? returnNew = null, bool? silent = null, CancellationToken cancellationToken = default) where T : class;
        Task<ArangoUpdateResult<TR>> UpdateAsync<T, TR>(ArangoHandle database, string collection, T doc, bool? waitForSync = null, bool? keepNull = null, bool? mergeObjects = null, bool? returnOld = null, bool? returnNew = null, bool? silent = null, CancellationToken cancellationToken = default) where T : class;
    }
}