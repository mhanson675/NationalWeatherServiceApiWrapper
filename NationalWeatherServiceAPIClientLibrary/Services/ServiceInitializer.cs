using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPIClientLibrary.Services
{
    public static class ServiceInitializer
    {
        public static IMapper InitializeAutoMapper()
        {
            MapperConfiguration mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<NWSProfile>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}