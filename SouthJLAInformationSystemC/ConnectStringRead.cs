using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthJLAInformationSystemC
{
    public class ConnectStringRead
    {
        public string text = System.IO.File.ReadAllText(@"connection.txt");
    }
}
