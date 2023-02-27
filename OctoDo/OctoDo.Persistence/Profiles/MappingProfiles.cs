using AutoMapper;
using OctoDo.Domain.Models;
using OctoDo.Persistence.DTOs;

namespace OctoDo.Persistence.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, ActivityDto>().ReverseMap();
        CreateMap<Plan, PlanDto>().ReverseMap();
        CreateMap<Routine, RoutineDto>().ReverseMap();
        CreateMap<ToDo, ToDoDto>().ReverseMap();
    }
}