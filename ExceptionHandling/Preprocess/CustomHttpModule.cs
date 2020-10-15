using System;
using System.IO;
using System.Web;

namespace ExceptionHandling.Preprocess
{
    public class CustomHttpModule : IHttpModule
    {
        public CustomHttpModule()
        { }
        public void Init(HttpApplication objApplication)
        {
            // Register event handler of the pipe line
            objApplication.BeginRequest += new EventHandler(this.context_BeginRequest);
            objApplication.EndRequest += new EventHandler(this.context_EndRequest);
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