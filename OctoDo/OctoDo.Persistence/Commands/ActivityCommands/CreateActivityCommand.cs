using AutoMapper;
using OctoDo.Domain.Commands.ActivityCommands;
using OctoDo.Domain.Models;
using OctoDo.Persistence.DTOs;

namespace OctoDo.Persistence.Commands.ActivityCommands;

public class CreateActivityCommand : ICreateActivityCommand
{
    private readonly DbContext _context;
    private readonly IMapper _mapper;

    public CreateActivityCommand(DbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Activity> ExecuteAsync(Activity activity)
    {
        await Task.Run(() =>
        {
            var activityDto = _mapper.Map<Activity, ActivityDto>(activity);
            _context.Database.Insert(activityDto);
        });

        return activity;
    }
}