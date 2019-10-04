using System;
using System.Collections.Generic;
using FizzBuzzModels;   
namespace FizzBuzzClient
{
    public interface IPersonClient
    {
        List<PersonModel> GetRecordsByBirthdate();
        List<PersonModel> GetRecordsByGender();
        List<PersonModel> GetRecordsByName();
    }
}
