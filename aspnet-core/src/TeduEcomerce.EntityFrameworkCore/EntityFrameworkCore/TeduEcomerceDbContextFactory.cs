using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TeduEcomerce.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TeduEcomerceDbContextFactory : IDesignTimeDbContextFactory<TeduEcomerceDbContext>
{
    public TeduEcomerceDbContext CreateDbContext(string[] args)
    {
        TeduEcomerceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TeduEcomerceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TeduEcomerceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TeduEcomerce.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
