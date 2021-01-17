using System;
using System.IO;
using System.Web;

namespace ExceptionHandling.Preprocess
{
    /*
      -   HTTPHandler and HTTPModule in ASP.NET

        -    HTTPHandlers [The Extension Based Preprocessor]
            : Inject pre-processing logic based on the extension of the file name requested

        -    HTTPModule [The Event Based Preprocessor]
            : can add own functionality working along with the default ASP.NET functionality

        -   MIME stands for Multipurpose Internet Mail Extensions. 
            It's a way of identifying files on the Internet according to their nature and format.
     */
    public class CustomHttpModule : IHttpModule
    {
        public void Init(HttpApplication objApplication)
        {
            // Register event handler of the pipe line
            objApplication.BeginRequest += this.context_BeginRequest;
            objApplication.EndRequest += this.context_EndRequest;
        }
        public void Dispose()
        {

        }
        public void context_EndRequest(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\requestLog.txt", true);
            sw.WriteLine("End Request called at " + DateTime.Now); sw.Close();
        }
        public void context_BeginRequest(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\requestLog.txt", true);
            sw.WriteLine("Begin request called at " + DateTime.Now); sw.Close();
        }

    }
}