using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestingAngular.Authorization.Roles;
using TestingAngular.Authorization.Users;
using TestingAngular.MultiTenancy;

namespace TestingAngular.EntityFrameworkCore
{
    public class TestingAngularDbContext : AbpZeroDbContext<Tenant, Role, User, TestingAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestingAngularDbContext(DbContextOptions<TestingAngularDbContext> options)
            : base(options)
        {
        }
    }
}
