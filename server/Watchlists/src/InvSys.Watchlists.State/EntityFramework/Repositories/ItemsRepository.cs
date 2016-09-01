﻿using System;
using InvSys.Shared.State.EntityFramework.Repositories;
using InvSys.Watchlists.Core.Models;
using InvSys.Watchlists.Core.State;

namespace InvSys.Watchlists.State.EntityFramework.Repositories
{
    public class ItemsRepository : BaseRepository<Item, Guid>, IItemsRepository
    {
        private readonly WatchlistsContext _watchlistsContext;
        public ItemsRepository(WatchlistsContext dbContext)
            : base(dbContext)
        {
            _watchlistsContext = dbContext;
        }

        public override Item Add(Item entity)
        {
            return base.Add(entity);
        }

        public override void Delete(Guid id)
        {
            base.Delete(id);
        }
    }
}
