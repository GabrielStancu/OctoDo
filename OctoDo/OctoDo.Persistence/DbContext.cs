using OctoDo.Persistence.DTOs;
using SQLite;

namespace OctoDo.Persistence;

public class DbContext
{
    public DbContext(string fileName)
    {
        Database ??= new SQLiteConnection("D:\\Projects\\OctoDo\\OctoDo\\OctoDo.db");

        Database.CreateTable<ActivityDto>();
        Database.CreateTable<PlanDto>();
        Database.CreateTable<RoutineDto>();
        Database.CreateTable<ToDoDto>();
    }

    internal SQLiteConnection Database { get; }
}