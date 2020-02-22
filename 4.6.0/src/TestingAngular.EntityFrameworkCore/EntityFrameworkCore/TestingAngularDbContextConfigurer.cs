using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestingAngular.EntityFrameworkCore
{
    public static class TestingAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestingAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestingAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
