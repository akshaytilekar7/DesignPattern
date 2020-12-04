using System;
using System.Globalization;
using System.IO;
using System.Web;

namespace ExceptionHandling.Preprocess
{
    public class CustomHttpHandler : IHttpHandler
    {
        public void ProcessRequest(System.Web.HttpContext context)
        {
            context.Response.Write("The page request is " + context.Request.RawUrl);
            StreamWriter sw = new StreamWriter(@"C:\requestLog.txt", true);
            sw.WriteLine("Page requested at " + DateTime.Now.ToString(CultureInfo.InvariantCulture) + context.Request.RawUrl); sw.Close();
        }
        public bool IsReusable => true;
    }
}