using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMakerFree.ViewModels;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMakerFree.Controllers
{
    [Route("api/[controller]")]
    public class QuizController : Controller
    {
        public List<QuizViewModel> SampleQuizze { get;  set; }
        public QuizController()
        {
            SampleQuizze = new List<QuizViewModel>();
        }
        // GET: api/values
        [HttpGet("Latest/{num}")]
        public IActionResult Latest(int num = 10)
        {
            RawData(num);
            var jsonSerialized = new JsonResult(SampleQuizze, new JsonSerializerSettings() { Formatting = Formatting.Indented });
            return jsonSerialized;
        }

        // GET api/values/5
        [HttpGet("ByTitle/{num:int?}")]
        public IActionResult ByTitle(int num)
        {
            RawData(num);
            return new JsonResult(SampleQuizze.OrderByDescending(x => x.Description).ToList(), new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        [HttpGet("Random/{num}")]
        public IActionResult Random(int num=10)
        {
            RawData(num);
            //https://stackoverflow.com/questions/41487665/what-is-guid-newguid-doing-in-linq-to-entities/41487705
            return new JsonResult(SampleQuizze.OrderBy
                (x => Guid.NewGuid()).ToList(), new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        private void RawData(int num)
        {
            for (int i = 0; i < num; i++)
            {
                SampleQuizze.Add(new QuizViewModel
                {
                    Id = i + 1,
                    Title = String.Format("Sample Quiz {0}", i + 1),
                    Description = ($"{i + 1}: This is a sample quiz"),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
