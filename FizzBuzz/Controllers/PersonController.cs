using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FizzBuzzService;
using FizzBuzzModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService) 
        {
            _personService = personService;
        }
        // GET: api/values
        [Route("gender/")]
        [HttpGet]
        public IEnumerable<PersonModel> GetByGender()
        {
            return new PersonModel[] { new PersonModel() { FirstName = "Implement Gender Get" } };
        }

        [Route("birthdate/")]
        [HttpGet]
        public IEnumerable<PersonModel> GetByBirthdate()
        {
            return new PersonModel[] { new PersonModel() { FirstName = "Implement Birthday Get" } };
        }
        [Route("name/")]
        [HttpGet]
        public IEnumerable<PersonModel> GetByName()
        {
            return new PersonModel[] { new PersonModel() { FirstName = "Implement Birthday Get" } };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string recordsRawText)
        {
            _personService.SaveRecords(recordsRawText);
        }


    }
}
