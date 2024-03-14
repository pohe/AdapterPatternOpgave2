using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternOpgave2
{
    public class NewSystem
    {
        private IDataService dataService;

        public NewSystem(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public void GetData()
        {
            // Brug af det fælles interface til at hente data, uanset hvilken service der bruges
            string data = dataService.RetrieveData();
            Console.WriteLine("Data received: " + data);
        }
    }
}
