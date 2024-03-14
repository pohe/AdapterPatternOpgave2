using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternOpgave2
{
    // Eksisterende service A med uforeneligt interface
    public class DataServiceA
    {
        public string RetrieveDataA()
        {
            return "Data from Service A";
        }
    }
}
