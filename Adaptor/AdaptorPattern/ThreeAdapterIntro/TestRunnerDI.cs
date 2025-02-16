using AdapterPattern.ThreeAdapterIntro.ActionAdapter;
using Xunit;

namespace AdapterPattern.ThreeAdapterIntro
{
    public class TestRunnerDI
    {
        [Fact]
        public void DisplayDataFrom_File()
        {
            var service = new DisplayServiceDI(new FileActionAdapter(@"People.json"));

            var result = service.GetDataFromFileOrDb(DataSourceType.File);

            Assert.Equal("\"from file source\"", result.ToString());

        }

        [Fact]
        public void DisplayDataFrom_DB()
        {
            var service = new DisplayServiceDI(new DbActionAdapter());

            var result = service.GetDataFromFileOrDb(DataSourceType.Database);

            Assert.Equal("from DB Source", result);

        }
    }
}
