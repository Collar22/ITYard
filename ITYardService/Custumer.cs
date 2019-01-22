using System;


namespace ITYardService
{
    class Custumer
    {
        int age;
        static string _country = "Ukraine";
        string _firstName;
        string _lastName;

        //static Custumer()
        //{
        //    _country = "Argentina";
        //}

        public Custumer(string firstName, string lastName, string country)
        {
            _country = country;
            _firstName = firstName;
            _lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full name is {_firstName} {_lastName} from country {_country}");
        }
    }



}
