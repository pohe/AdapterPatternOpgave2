// See https://aka.ms/new-console-template for more information
using AdapterPatternOpgave2;

Console.WriteLine("Hello, Adapter pattern!");


// Brug af adapteren for DataServiceA i det nye system
DataServiceA dataServiceA = new DataServiceA();
//IDataService dataServiceAAdapter = new DataServiceAAdapter(dataServiceA);
//NewSystem systemWithServiceA = new NewSystem(dataServiceAAdapter);
//systemWithServiceA.GetData();

// Brug af adapteren for DataServiceB i det nye system
DataServiceB dataServiceB = new DataServiceB();
//IDataService dataServiceBAdapter = new DataServiceBAdapter(dataServiceB);
//NewSystem systemWithServiceB = new NewSystem(dataServiceBAdapter);
//systemWithServiceB.GetData();