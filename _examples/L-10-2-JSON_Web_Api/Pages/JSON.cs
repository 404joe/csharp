using Microsoft.AspNetCore.Mvc;
using System.Text.Json; 

namespace YourNamespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyJSON : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            string jsonRes = // "" -> Quote Escaping, in the .NET template you write double "", in the browser appears a single "
                @"[{""StudentID"":1022,""ClassID"":""101-07"",""Advisor"":""Jones"",""Room"":412,""Dept"":42},
                   {""StudentID"":1022,""ClassID"":""143-01"",""Advisor"":""Jones"",""Room"":412,""Dept"":42},
                   {""StudentID"":1022,""ClassID"":""159-02"",""Advisor"":""Jones"",""Room"":412,""Dept"":42},
                   {""StudentID"":4123,""ClassID"":""101-07"",""Advisor"":""Smith"",""Room"":216,""Dept"":42},
                   {""StudentID"":4123,""ClassID"":""143-01"",""Advisor"":""Smith"",""Room"":216,""Dept"":42},
                   {""StudentID"":4123,""ClassID"":""179-04"",""Advisor"":""Smith"",""Room"":216,""Dept"":42}]";
                
            return Ok(jsonRes);  // Console.WriteLine(jsonRes);
        }
    }
}        
