using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HH.Api;
using HH.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VacanciesService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActualVacanciesController : ControllerBase
    {
        private HHApiRequest HhApiRequest;

        public ActualVacanciesController()
        {
            HhApiRequest = new HHApiRequest();
        }

        [HttpGet]
        public async Task<IEnumerable<Vacancy>> Get()
        {
            string response = await HhApiRequest.Get();
            IEnumerable<Vacancy> parsed = HHApiConverter.FromJson(response);
            return parsed;
        }

        [HttpGet("searchByName")]
        public async Task<IEnumerable<Vacancy>> Get(string searchString)
        {
            var list = await Get();
            if (string.IsNullOrEmpty(searchString))
                return list;
            return list.Where(i => i.Name.Trim().ToLower().Contains(searchString.Trim().ToLower())).ToList();
        }
    }
}