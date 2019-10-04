using System;
using System.Collections.Generic;
using FizzBuzzModels;
using FizzBuzzRepository;

namespace FizzBuzzService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<PersonModel> GetRecordsByBirthdate()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetRecordsByGender()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetRecordsByName()
        {
            throw new NotImplementedException();
        }

        public bool SaveRecords(string inputText)
        {
            throw new NotImplementedException();
        }
    }
}
