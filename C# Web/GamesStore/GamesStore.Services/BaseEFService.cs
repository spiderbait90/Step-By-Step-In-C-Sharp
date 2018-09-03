using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GamesStore.Data;

namespace GamesStore.Services
{
    public abstract class BaseEFService
    {
        protected BaseEFService(
            GamesStoreContext dbContext,
            IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        protected GamesStoreContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }
    }
}
