using System;
using System.Collections.Generic;
using FizzBuzzModels;
namespace FizzBuzzService
{
    public interface IPersonService
    {
        List<PersonModel> GetRecordsByBirthdate();
        List<PersonModel> GetRecordsByGender();
        List<PersonModel> GetRecordsByName();
        bool SaveRecords(string inputText);
    }
}
