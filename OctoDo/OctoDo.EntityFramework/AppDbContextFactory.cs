using Microsoft.EntityFrameworkCore;

namespace OctoDo.EntityFramework;

public class AppDbContextFactory : IDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder()
            .UseSqlite("Data Source=OctoDo.db")
            .Options;

        return new AppDbContext(options);
    }
}