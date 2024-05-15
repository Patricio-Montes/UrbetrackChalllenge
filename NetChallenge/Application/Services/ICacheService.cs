﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NetChallenge.Application.Services
{
    public interface ICacheService
    {
        Task<T> GetAsync<T>(string key, CancellationToken cancellationToken = default)
            where T : class;

        Task<T> GetAsync<T>(string key, Func<Task<T>> factory, CancellationToken cancellationToken = default)
            where T : class;

        Task<List<T>> GetAllAsync<T>(string keyPrefix, CancellationToken cancellationToken = default)
            where T : class;

        Task SetAsync<T>(string key, T value, CancellationToken cancellationToken = default)
            where T : class;

        Task RemoveAsync(string key, CancellationToken cancellationToken = default);

        Task RemoveByPrefixAsync(string prefixKey, CancellationToken cancellationToken = default);
    }
}