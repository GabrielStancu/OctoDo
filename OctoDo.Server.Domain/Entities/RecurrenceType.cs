namespace OctoDo.Server.Domain.Entities;
public enum RecurrenceType
{
    Daily, // Activities scheduled to repeat every day
    Weekly, // Activities scheduled to repeat during specific days of the week
    Monthly, // Activities scheduled to repeat during specific days of the month
    Yearly, // Activities scheduled to repeat during specific days of the year
    Fixed // Activities scheduled to repeat only on fixed dates
}
