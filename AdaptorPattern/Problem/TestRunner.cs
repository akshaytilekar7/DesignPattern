using Xunit;

namespace AdapterPattern.Problem
{
    public class TestRunner
    {

        [Fact]
        public void DisplayDataFrom_File()
        {
            var service = new DisplayService();

            var result = service.GetDataFromFileOrDb(DataSourceType.File);

            Assert.Equal("\"from file source\"", result.ToString());
        }

        [Fact]
        public void DisplayDataFrom_DB()
        {
            var service = new DisplayService();

            var result = service.GetDataFromFileOrDb(DataSourceType.Database);

            Assert.Equal("from DB Source", result);
        }
    }
}
