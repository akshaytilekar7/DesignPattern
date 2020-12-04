//https://app.pluralsight.com/guides/understand-control-flow-async-await
//https://app.pluralsight.com/guides/csharp-async-await-keywords-getting-started
//https://app.pluralsight.com/guides/using-task-run-async-await

//using System;
//using System.Threading.Tasks;

//namespace DesignPattern.CSharp
//{
//    class AsyncAwait
//    {
//        /*
//            calling res.Result or Wait() will cause synchronous operation,
//            UI will block in that case, its a bad idea
//            await keyword causing CONTINUATION allowing us to get back to original context
//            public async void GetData() // avoid async await at any cost

//        2]

//        */

//        public async Task GetData()
//        {
//            // NO return statement but still we don't have any COMPILATION ERROR 
//            // compiler do that things for us
//            await GetData();
//        }


//        /*
//        ALWAYS use await keyword to validate our task
//        exceptions occured in ASYNC VOID can not be caught so use async void 

//        TASK 
//            -   represent an Asynchronous operations

//        Task.Run() - queue the work by scope to run on different thread

//         */
//        void OnButtonClick()
//        {
//            DownloadAndBlur("https://...jpg");
//            ShowDialog("Success!");
//        }

//        async Task DownloadAndBlur(string url)
//        {
//            await DownloadImage(...);
//            await BlurImage(...);
//            await SaveImage(...);
//        }

//        /*
//            If you were to run this code you would notice a problem: 
//            The success dialog displays before the download/blur operation completes!
//            This demonstrates an important point:
//            When a method using await is not itself awaited, 
//            EXECUTION OF THE CALLING METHOD (OnButtonClick)
//              CONTINUES BEFORE THE CALLED (DownloadAndBlur) METHOD HAS COMPLETED.
//         */

//        void OnButtonClick()
//        {
//            Console.WriteLine("button clicked");
//            DownloadAndBlur("https://...jpg");
//            Console.WriteLine("about to show dialog");
//            ShowDialog("Success!");
//            Console.WriteLine("dialog shown");
//        }

//        async Task DownloadAndBlur(string url)
//        {
//            Console.WriteLine("about to download");
//            await DownloadImage(...);
//            Console.WriteLine("finished downloading, about to blur");
//            await BlurImage(...);
//            Console.WriteLine("finished blurring, about to save");
//            await SaveImage(...);
//            Console.WriteLine("finished saving");
//        }
//        // Output
//        //button clicked
//        //about to download
//        //about to show dialog
//        //dialog shown "Success!!"
//        //finished downloading, about to blur
//        //finished blurring, about to save
//        //finished saving

//        //Notice that, at first, execution of DownloadAndBlur is performed synchronously,
//          until the first encounter with await.
//        // Control at that time returns to the calling method as if
//          DownloadAndBlur had already finished.

//        //fix by
//        async void OnButtonClick()
//        {
//            Console.WriteLine("button clicked");
//            await DownloadAndBlur("https://...jpg");
//            Console.WriteLine("about to show dialog");
//            ShowDialog("Success!");
//            Console.WriteLine("dialog shown");
//        }
//    }
//}
