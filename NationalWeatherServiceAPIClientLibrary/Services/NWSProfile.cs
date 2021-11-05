using AutoMapper;
using NationalWeatherServiceAPIClientLibrary.Models;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPIClientLibrary.Services
{
    public class NWSProfile : Profile
    {
        public NWSProfile()
        {
            //    CreateMap<StationObservationsLatestResponse, CurrentConditionsResponse>()
            //        .ForMember(dest => dest.ObservationDate, opt => opt.MapFrom(src => src.Properties.Timestamp))
            //        .ForMember(dest => dest.Temperature, opt => opt.MapFrom(src => src.Properties.Temperature.Value))
            //        .ForMember(dest => dest.DewPoint, opt => opt.MapFrom(src => src.Properties.Dewpoint.Value))
            //        .ForMember(dest => dest.WindDirection, opt => opt.MapFrom(src => src.Properties.WindDirection.Value))
            //        .ForMember(dest => dest.WindSpeed, opt => opt.MapFrom(src => src.Properties.WindSpeed.Value))
            //        .ForMember(dest => dest.WindGust, opt => opt.MapFrom(src => src.Properties.WindGust.Value))
            //        .ForMember(dest => dest.BarometricPressure, opt => opt.MapFrom(src => src.Properties.BarometricPressure.Value))
            //        .ForMember(dest => dest.SeaLevelPressure, opt => opt.MapFrom(src => src.Properties.SeaLevelPressure.Value))
            //        .ForMember(dest => dest.Visibility, opt => opt.MapFrom(src => src.Properties.Visibility.Value))
            //        .ForMember(dest => dest.RelativeHumidity, opt => opt.MapFrom(src => src.Properties.RelativeHumidity.Value))
            //        .ForMember(dest => dest.WindChill, opt => opt.MapFrom(src => src.Properties.WindChill.Value))
            //        .ForMember(dest => dest.HeatIndex, opt => opt.MapFrom(src => src.Properties.HeatIndex.Value));

            //    CreateMap<ObservationStation, WeatherStation>()
            //        .ForMember(dest => dest.StationIdentifier, opt => opt.MapFrom(src => src.Properties.StationIdentifier))
            //        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Properties.Name))
            //        .ForMember(dest => dest.Elevation, opt => opt.MapFrom(src => src.Properties.Elevation.Value))
            //        .ForMember(dest => dest.Coordinates, opt => opt.MapFrom(src => src.Geometry.Coordinates));
        }
    }
}