using OctoDo.Domain.Commands.PlanCommands;
using OctoDo.Domain.Models;
using OctoDo.Domain.Queries.PlanQueries;

namespace OctoDo.Presentation.Stores;

public class PlansStore
{
    public event Action? PlansLoaded;
    public event Action? PlanCreated;
    public event Action? PlanDisabled;
    public event Action? PlanUpdated;
    public event Action? PlanSelected;
    public IEnumerable<Plan> Plans => _plans;

    private readonly IGetAllPlansQuery _getAllPlansQuery;
    private readonly ICreatePlanCommand _createPlanCommand;
    private readonly IDisablePlanCommand _disablePlanCommand;
    private readonly IUpdatePlanCommand _updatePlanCommand;

    private List<Plan> _plans;

    public PlansStore(
        IGetAllPlansQuery getAllPlansQuery, 
        ICreatePlanCommand createPlanCommand, 
        IDisablePlanCommand disablePlanCommand, 
        IUpdatePlanCommand updatePlanCommand)
    {
        _getAllPlansQuery = getAllPlansQuery;
        _createPlanCommand = createPlanCommand;
        _disablePlanCommand = disablePlanCommand;
        _updatePlanCommand = updatePlanCommand;

        _plans = new List<Plan>();
    }

    public async Task LoadAsync()
    {
        var activePlans = await _getAllPlansQuery.ExecuteAsync();

        _plans.Clear();
        _plans.AddRange(activePlans);

        PlansLoaded?.Invoke();
    }

    public async Task CreateAsync(Plan plan)
    {
        var createdPlan = await _createPlanCommand.ExecuteAsync(plan);

        _plans.Add(createdPlan);
        PlanCreated?.Invoke();
    }

    public async Task UpdateAsync(Plan plan)
    {
        var updatedPlan = await _updatePlanCommand.ExecuteAsync(plan);
        var currentIndex = _plans.FindIndex(p => p.Id == plan.Id);

        if (currentIndex != -1)
        {
            _plans[currentIndex] = updatedPlan;
        }
        else
        {
            _plans.Add(updatedPlan);
        }

        PlanUpdated?.Invoke();
    }

    public async Task DisableAsync(Plan plan)
    {
        var disabledPlan = await _disablePlanCommand.ExecuteAsync(plan);

        _plans.RemoveAll(p => p.Id == disabledPlan.Id);

        PlanDisabled?.Invoke();
    }

    public async Task SelectPlanAsync(Plan plan)
    {
        if (!HasActivePlanForToday)
        {
            plan.IsSelectedForToday = true;
            await _updatePlanCommand.ExecuteAsync(plan);
            PlanSelected?.Invoke();
        }
    }

    public bool HasActivePlanForToday => _plans.Any(p => p.IsSelectedForToday);
}