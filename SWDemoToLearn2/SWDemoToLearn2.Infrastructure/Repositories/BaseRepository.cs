﻿/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using AutoMapper;
using SWDemoToLearn2.Data.Database;

namespace SWDemoToLearn2.Infrastructure.Repositories
{
    public class BaseRepository
    {
        public readonly IMapper _iMapper;
        public readonly BaseDbContext _baseDbContext;

        public BaseRepository(BaseDbContext _baseDbContext, IMapper _iMapper)
        {
            this._iMapper = _iMapper;
            this._baseDbContext = _baseDbContext;
        }
    }
}
