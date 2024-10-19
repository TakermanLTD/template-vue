using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Takerman.Template.Services;
using Takerman.Template.Services.Abstraction;
using Xunit.Microsoft.DependencyInjection;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Takerman.Template.Tests
{
    public class TestFixture : TestBedFixture
    {
        protected override void AddServices(IServiceCollection services, IConfiguration? configuration)
            => services
                .AddTransient<ITemplateService, TemplateService>();

        protected override ValueTask DisposeAsyncCore() => new();

        protected override IEnumerable<TestAppSettings> GetTestAppSettings()
        {
            var result = new List<TestAppSettings>()
            {
                new(){ Filename = "test-appsettings.json", IsOptional = false },
                new(){ Filename = "test-appsettings.Production.json", IsOptional = true }
            };

            return result;
        }
    }
}