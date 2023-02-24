using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OctoDo.EntityFramework;

public class AppDesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder()
            .UseSqlite("Data Source=OctoDo.db")
            .Options;

        return new AppDbContext(options);
    }
}