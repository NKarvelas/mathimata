using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathima
{
    internal class DBContext
    {
        string _options;

        public DBContext(string options) 
        {
            _options = options;
        }
    }
}
