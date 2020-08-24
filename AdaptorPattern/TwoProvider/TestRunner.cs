using Xunit;
using Xunit.Abstractions;

namespace AdapterPattern.TwoProvider
{
    public class TestRunner
    {
        private readonly ITestOutputHelper _output;

        public TestRunner(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void DisplayDataFrom_File()
        {
            var service = new DisplayService();

            var result = service.GetDataFromFileOrDb(DataSourceType.File);

            _output.WriteLine(result);
        }

        [Fact]
        public void DisplayDataFrom_DB()
        {
            var service = new DisplayService();

            var result = service.GetDataFromFileOrDb(DataSourceType.Database);

            _output.WriteLine(result);
        }
    }
}
