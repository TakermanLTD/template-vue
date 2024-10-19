using Takerman.Template.Services.Abstraction;
using Xunit.Abstractions;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Takerman.Template.Tests.Integration
{
    public class MailTests : TestBed<TestFixture>
    {
        private readonly ITemplateService _templateService;

        public MailTests(ITestOutputHelper testOutputHelper, TestFixture fixture)
        : base(testOutputHelper, fixture)
        {
            _templateService = _fixture.GetService<ITemplateService>(_testOutputHelper);
        }

        [Fact]
        public void Should_PassCorrectly_When_RunTheTest()
        {
            Assert.True(true);
        }
    }
}