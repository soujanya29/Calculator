using CalculatorTest.BusinessLogicLayer;
using System;
using System.Web.Http;

namespace CalculatorTest.MathsAPI.Controllers
{

    public class CalculatorController : ApiController
    {
        private readonly ISimpleCalculator _iCalculator;

        int result;

        #region Construction
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorController" /> class.
        /// </summary>
        /// <param name="contribution"></param>
        public CalculatorController(ISimpleCalculator iCalculator)
        {
            _iCalculator = iCalculator;

        }
        #endregion


        /// <summary>
        /// This Method will return Addition of two numbers
        /// </summary>
        [HttpGet]
        [Route("api/calculator/Add/{input1}/{input2}")]
        // GET: api/Calculator/Add/5/6
        public IHttpActionResult Add(int input1, int input2)
        {
            try
            {
                result = _iCalculator.Add(input1, input2);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Addition failed"));
            }

        }

        /// <summary>
        /// This Method will return subtract of two numbers
        /// </summary>
        [HttpGet]
        [Route("api/calculator/Subtract/{input1}/{input2}")]
        public IHttpActionResult Subtract(int input1, int input2)
        {
            try
            {
                result = _iCalculator.Subtract(input1, input2);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Subtraction failed"));
            }
        }

        /// <summary>
        /// This Method will return multiplication of two numbers
        /// </summary>
        [HttpGet]
        [Route("api/calculator/Multiply/{input1}/{input2}")]
        public IHttpActionResult Multiply(int input1, int input2)
        {
            try
            {
                result = _iCalculator.Multiply(input1, input2);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Multiplication failed"));
            }
        }

        /// <summary>
        /// This Method will return division of two numbers
        /// </summary>
        [HttpGet]
        [Route("api/calculator/Divide/{input1}/{input2}")]
        public IHttpActionResult Divide(int input1, int input2)
        {
            try
            {
               result = _iCalculator.Divide(input1, input2);
               return Ok(result);
            }
            catch (DivideByZeroException)
            {
                return InternalServerError(new Exception("DivideByZeroException"));
            }
        }
    }

}
