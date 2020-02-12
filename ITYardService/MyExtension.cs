using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
   public static class MyExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
