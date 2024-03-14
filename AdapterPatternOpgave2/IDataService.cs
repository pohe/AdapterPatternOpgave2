using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternOpgave2
{
    // Fælles interface, som det nye system forventer
    public interface IDataService
    {
        string RetrieveData();
    }
}
