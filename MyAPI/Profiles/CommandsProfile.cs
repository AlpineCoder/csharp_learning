using AutoMapper;
using MyAPI.Dtos;
using MyAPI.Models;

namespace MyAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}