using System;

namespace CalculatorTest.CalculatorApp
{
    public class Program
    {       
        private static InterfaceHandler _interfaceHandler = new InterfaceHandler();

        static void Main(string[] args)
        {
            try
            {
                Bootstrapper.Init();
                MathsApi _mathsApi = DependencyInjector.Retrieve<MathsApi>();

                var userRequest = _interfaceHandler.HandleRequest();

                //Retrieving the results from WebAPI
                var output = _mathsApi.ExecuteRequest(userRequest.Input1, userRequest.Input2, userRequest.Action);
                Console.WriteLine("Result=" + output);

                //Save records into database
                Console.WriteLine("Press 1 for saving results using EF");
                Console.WriteLine("Press 2 for saving results using ADO.Net");
                bool savedResult = false;
                int result = Convert.ToInt32(output);
                string response = Console.ReadLine();
                if (response == "1")
                {
                    savedResult = _mathsApi.SaveRequest(userRequest.Input1, userRequest.Input2, userRequest.Action, result);
                }
                else if (response == "2")
                {
                   savedResult = _mathsApi.InsertRequest(userRequest.Input1, userRequest.Input2, userRequest.Action, result);
                }
                if (savedResult == true)
                    Console.WriteLine("Record Saved successfully");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
                Console.Write("Please press any key to end the program");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }      
    }   
}
