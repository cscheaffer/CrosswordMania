using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CrosswordDLL
{
    class Helper
    {
        public static string CnnVal()
        {
            return "Server = tcp:oatmealrains.database.windows.net,1433; Initial Catalog = Crossword; Persist Security Info = False; User ID = username; Password =password; MultipleActiveResultSets = False; Encrypt = False; Connection Timeout = 30; Integrated Security=False ";
        }
    }
}
