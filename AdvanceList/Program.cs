using AdvanceList.DataGenerator;
using AdvanceList.Library;

namespace AdvanceList
{
    public class Test
    {
        static void Main(string[] args)
        {
            AvlManagement avlManagement = new AvlManagement();
            Console.WriteLine("START START START START START START");
            int count = 100000;
            DummyDataService dummyDataService = new DummyDataService(avlManagement, count);

            // Console.WriteLine("SAME??? : " + dummyDataService.AreSame());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            var lstTraditional = dummyDataService.GetDataTraditional();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Traditional Create Total time : " + elapsedMs);

            watch = System.Diagnostics.Stopwatch.StartNew();
            var lstNewWay = dummyDataService.GetDataNewWay();
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("AVL Create Total time : " + elapsedMs);

            var dbIds = dummyDataService.GetAllByRandomIds().Take(50);
            foreach (var ID in dbIds)
            {
                watch = System.Diagnostics.Stopwatch.StartNew();
                var data = lstTraditional.FirstOrDefault(x => x.Id == ID);
                //Console.WriteLine("tra data - " + data.Name);
                watch.Stop();
                elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("     Traditional Search Total time : " + elapsedMs);

                watch = System.Diagnostics.Stopwatch.StartNew();
                var avlData = avlManagement.GetNode(ID);
                //Console.WriteLine("new data - " + avlData.Data.Name);
                watch.Stop();
                elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("     AVL  Search Total time : " + elapsedMs);
            }
            Console.WriteLine("END END END END END END END END");
            Console.ReadLine();
        }
    }
}