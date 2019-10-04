using System;
using FizzBuzzModels;
namespace FizzBuzzRepository
{
    public interface IPersonRepository
    {
        PersonModel GetRecords();
        bool SaveRecords();
    }
}
