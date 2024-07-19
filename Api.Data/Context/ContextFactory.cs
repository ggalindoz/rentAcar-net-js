using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {

        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost\\SQLEXPRESS;Database=galindo;Uid=josimar;Pwd=123";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}

