using AutoMapper;
using DioklecijanovaLegija.Dtos;
using DioklecijanovaLegija.Models;

namespace DioklecijanovaLegija.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Member, MemberDto>();
            Mapper.CreateMap<Event, EventDto>();



            Mapper.CreateMap<MemberDto, Member>()
               .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<EventDto, Event>();
        }
    }
}
