using CalculatorTest.DataAccessLayer.ADO;
using CalculatorTest.DataAccessLayer.Repository;
using System;
using System.IO;
using System.Net;

namespace CalculatorTest.CalculatorApp
{
    public class MathsApi
    {
        private readonly WebClient client = new WebClient();
        private readonly InterfaceHandler _interfaceHandler = new InterfaceHandler();

        private readonly ICalculatorRepository _iRepository;
        private readonly ICalculatorAdo _iCalculator;

        public MathsApi(ICalculatorRepository iRepository, ICalculatorAdo iCalculator)
        {
            _iRepository = iRepository;
            _iCalculator = iCalculator;

        }
       
        public string ExecuteRequest(int input_1, int input_2, MethodType action)
        {
            try
            { 
            var requestString = $"http://localhost:50705/api/calculator/{action}/{input_1}/{input_2}";
            var result = client.DownloadString(requestString);
            return result;
            }
            catch(WebException webEx)
            {
                var body = new StreamReader(webEx.Response.GetResponseStream()).ReadToEnd();
                Console.WriteLine("Message :{0}", body);
                throw webEx;
            }
        }      

        public bool SaveRequest(int input_1, int input_2, MethodType action, int result)
        {            
           return _iRepository.SaveResult((int)action, input_1, input_2, result);
        
        }

        public bool InsertRequest(int input_1, int input_2, MethodType action, int result)
        {

           return _iCalculator.InsertResults((int)action, input_1, input_2, result);
            
        }


    }
}
