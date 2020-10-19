using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RPSAPI.Controllers
{
    [Route("ResultController")]

    public class ResultController : ControllerBase
    {
       

        public ResultController()
        {


            
        }

        [HttpPost]
        public IDictionary<string, string> Post(IDictionary<string, string> playRequest)
        {
            var dictionary = new Dictionary<string, string>();
            string value = playRequest["PlayerChoice"];

            //Create an array, use a random generator to select one of the 3 things, 
            //if or else the matches//
            //

            dictionary.Add("PlayerChoice", value);
            dictionary.Add("CpuChoice", "Rock");
            dictionary.Add("Result", "Win");

            return dictionary;




        }
    }
}
