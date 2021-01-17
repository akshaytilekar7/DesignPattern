/*


Asynchronous programming
    -   general in that it has to do with latency (something on which your application has to wait, for one reason or another)

multi-threaded programming
    -   achieve parallelization (1/more things that your application has to do at the same time))

Task Parallel Library [4.0]
    -   async and await  not possibile without TPL
    -   introduced to address parallelization
    -   requirements for multithreaded programming are very similar to that of asynchronous programming in general
    -   so, introduced a beautiful abstraction called a Task
    -    DownloadImage(url).ContinueWith(task1 =>) defines an additional task that corresponds to what should happen when the previous task completes
    -   not readabel due to callbacks

*/

using System;
using System.IO;
using System.Threading.Tasks;

public class T
{
    static Task<byte[]> DownloadImage(string url) { return null; }

    static Task<byte[]> BlurImage(string imagePath) { return null; }

    static Task SaveImage(byte[] bytes, string imagePath) { return null; }
    public T()
    {
        bool done = false;
        var url = "https://...jpg";
        var fileName = url;
        var ImageResourcesPath = "";
        DownloadImage(url).ContinueWith(task1 =>
        {
            var originalImageBytes = task1.Result;
            var originalImagePath = Path.Combine("", fileName);
            SaveImage(originalImageBytes, originalImagePath).ContinueWith(task2 =>
            {
                BlurImage(originalImagePath).ContinueWith(task3 =>
                {
                    var blurredImageBytes = task3.Result;
                    var blurredFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_blurred.jpg";
                    var blurredImagePath = Path.Combine("", blurredFileName);
                    SaveImage(blurredImageBytes, blurredImagePath).ContinueWith(task4 =>
                    {
                        done = true;
                    });
                });
            });
        });

        while (!done) { /* update the dashboard */ }

        Console.WriteLine("Done!");
    }

    static async void DownloadAndBlur()
    {
        var url = "https://...jpg";
        var fileName = Path.GetFileName(url);
        var originalImageBytes = await DownloadImage(url);
        var originalImagePath = Path.Combine("", fileName);
        await SaveImage(originalImageBytes, originalImagePath);
        var blurredImageBytes = await BlurImage(originalImagePath);
        var blurredFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_blurred.jpg";
        var blurredImagePath = Path.Combine("", blurredFileName);
        await SaveImage(blurredImageBytes, blurredImagePath);
        var done = true;
    }

    public T(string o)
    {
        var await = 110;
        var async = 10;
    }
}