using OctoDo.Persistence.DTOs;
using SQLite;

namespace OctoDo.Persistence;

public class DbContext
{
    public DbContext(string fileName)
    {
        Connection ??= new SQLiteConnection("D:\\Projects\\OctoDo\\OctoDo\\OctoDo.db");

        Connection.CreateTable<ActivityDto>();
        Connection.CreateTable<PlanDto>();
        Connection.CreateTable<RoutineDto>();
        Connection.CreateTable<ToDoDto>();
    }

    internal SQLiteConnection Connection { get; }
}