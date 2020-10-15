using ExceptionHandling.ExceptionHelper;
using ExceptionHandling.Models;
using System;
using System.Web.Mvc;

namespace ExceptionHandling.Controllers
{
    [ExceptionHandling]
    public class C2VDataPassController : Controller
    {
        public void way1_HttpRequestBase()
        {
            string strName = Request["txtName"];
        }

        public void way2_FormCollection(FormCollection form)
        {
            string strName = form["txtName"];
        }
        public void way3_ThroughParameters(string txtName)
        {
            string strName = Convert.ToString(txtName);
        }

        public void way4_StronglyTypedView(User user)
        {
            string strName = user.Name;
        }


    }
}
