﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NetChallenge.Abstractions;
using NetChallenge.Application.Data;
using NetChallenge.Domain;

namespace NetChallenge.Infrastructure
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly IApplicationPersistence<Office> _persistence;

        public OfficeRepository(IApplicationPersistence<Office> persistence)
        {
            _persistence = persistence ?? throw new System.ArgumentNullException(nameof(persistence));
        }

        public IEnumerable<Office> AsEnumerable()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Office>> GetAllAsync()
        {
            return await _persistence.GetAllAsync();
        }

        public async Task Add(Office item)
        {
            await _persistence.AddAsync(item);
        }
    }
}