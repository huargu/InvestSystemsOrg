﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvSys.Watchlists.Core.Models;
using InvSys.Watchlists.Core.State;

namespace InvSys.Watchlists.Core.Services
{
    public class WatchlistsService : IWatchlistsService
    {
        private readonly IWatchlistsRepository _watchlistsRepository;
        private readonly IItemsRepository _itemsRepository;

        public WatchlistsService(IWatchlistsRepository watchlistsRepository, IItemsRepository itemsRepository)
        {
            _watchlistsRepository = watchlistsRepository;
            _itemsRepository = itemsRepository;
        }

        public async Task<Watchlist> AddWatchlist(Watchlist company)
        {
            var addedWatchlist = _watchlistsRepository.Add(company);
            if (await _watchlistsRepository.SaveChangesAsync())
            {
                return addedWatchlist;
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteWatchlist(Guid id)
        {
            _watchlistsRepository.Delete(id);
            return await _watchlistsRepository.SaveChangesAsync();
        }

        public async Task<Item> AddItem(Guid watchlistId, Item item)
        {
            var addedItem = _itemsRepository.Add(item);
            if (await _itemsRepository.SaveChangesAsync())
            {
                return addedItem;
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteItem(Guid id)
        {
            _itemsRepository.Delete(id);
            return await _itemsRepository.SaveChangesAsync();
        }

        public async Task<ICollection<Watchlist>> GetWatchlists()
        {
            return await _watchlistsRepository.GetAll();
        }

        public async Task<Watchlist> GetWatchlist(Guid id)
        {
            return await _watchlistsRepository.Get(id);
        }

        public async Task<Watchlist> UpdateWatchlist(Watchlist company)
        {
            _watchlistsRepository.Update(company);
            if (await _watchlistsRepository.SaveChangesAsync())
            {
                return company;
            }
            else
            {
                return null;
            }
        }
    }
}
