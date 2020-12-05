using System;
using System.Collections.Generic;
using System.Text;

namespace XpackHackathon.Utils.Helpers
{
    public static class RandomHelper
    {
        public static string Generate()
        {
            Random generator = new Random();
            int r = generator.Next(100000, 1000000);
            return r.ToString();
        } 
       
    }
}
