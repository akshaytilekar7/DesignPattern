using System;
using System.Collections.Generic;

namespace DesignPattern.Partial
{
    public class Database
    {
        internal void Add(string postMessage)
        {
            throw new NotImplementedException();
        }

        internal void AddAsTag(string postMessage)
        {
            throw new NotImplementedException();
        }

        internal void NotifyUser(string user)
        {
            throw new NotImplementedException();
        }

        internal List<string> getUnhandledPostsMessages()
        {
            throw new NotImplementedException();
        }
    }
}