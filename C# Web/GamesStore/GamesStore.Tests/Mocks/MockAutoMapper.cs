using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GamesStore.Web.AutoMapper;

namespace GamesStore.Tests.Mocks
{
    public static class MockAutoMapper
    {
        public static IMapper GetMapper()
        {
            AutoMapper.Mapper.Initialize(x => x.AddProfile<AutoMapperProfile>());
            return Mapper.Instance;
        }
    }
}
