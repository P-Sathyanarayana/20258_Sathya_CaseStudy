using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Person
    {
        /// <summary>
        /// Create a reference type called Person. Populate the Person class with the following 
        ///properties to store the following information:
        ///First name, Last name ,Email address ,Date of birth
        /// </summary>
        string firstName, lastName, emailAdd;
        DateTime Dob;
        int age;
        public Person(string firstName,string lastName,string emailAdd,DateTime Dob)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAdd = emailAdd;
            this.Dob = Dob;

        }
        public Person(string firstName, string lastName, string emailAdd)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAdd = emailAdd;

        }
        public Person(string firstName, string lastName, DateTime Dob)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Dob = Dob;
        }
        public string adult()
        {
            DateTime today = DateTime.Today;
            this.age = today.Subtract(this.Dob).Days;
            this.age = this.age / 365;
            if(this.age>=18)
            {
                return $"{this.firstName} is an adult aged {this.age}";
            }
            else
            {
                return $"{this.firstName} is not an adult aged {this.age}";
            }
            
        }
        public string Sunsign()
        {
            if (((this.Dob.Month == 03)&& (this.Dob.Day>=21)) || ((this.Dob.Month == 04) && (this.Dob.Day < 20)))
            {
                return $"The sun sign is Aries";
            }
            else if(( (this.Dob.Month == 04)&& (this.Dob.Day >= 20)) || ((this.Dob.Month == 05) && (this.Dob.Day <= 20)))
            {
                return $"The sun sign is Taurus";
            }
            else if (((this.Dob.Month == 05)&& (this.Dob.Day >= 21)) || ((this.Dob.Month == 06) && (this.Dob.Day <= 21)))
            {
                return $"The sun sign is Gemini";
            }
            else if (((this.Dob.Month == 06)&& (this.Dob.Day >= 22)) || ((this.Dob.Month == 07) && (this.Dob.Day <= 22)))
            {
                return $"The sun sign is Cancer";
            }
            else if (((this.Dob.Month == 07) && (this.Dob.Day >= 23)) || ((this.Dob.Month == 08) && (this.Dob.Day <= 22)))
            {
                return $"The sun sign is Leo";
            }
            else if (((this.Dob.Month == 08) && (this.Dob.Day >= 23)) || ((this.Dob.Month == 09) && (this.Dob.Day <= 22)))
            {
                return $"The sun sign is Virgo";
            }
            else if (((this.Dob.Month == 09) && (this.Dob.Day >= 23)) || ((this.Dob.Month == 10) && (this.Dob.Day <= 23)))
            {
                return $"The sun sign is Libra";
            }
            else if (((this.Dob.Month == 10) && (this.Dob.Day >= 24)) || ((this.Dob.Month == 11) && (this.Dob.Day <= 21)))
            {
                return $"The sun sign is Scorpius";
            }
            else if (((this.Dob.Month == 11) && (this.Dob.Day >= 22)) || ((this.Dob.Month == 12) && (this.Dob.Day <= 21)))
            {
                return $"The sun sign is Sagittarius";
            }
            else if (((this.Dob.Month == 12) && (this.Dob.Day >= 22)) || ((this.Dob.Month == 01) && (this.Dob.Day <= 19)))
            {
                return $"The sun sign is Capricornus";
            }
            else if (((this.Dob.Month == 01) && (this.Dob.Day >= 20)) || ((this.Dob.Month == 02) && (this.Dob.Day <= 18)))
            {
                return $"The sun sign is Aquarius";
            }
            else 
            {
                return $"The sun sign is Pisces";
            }

        }
        public string ChineseSign()
        {
            if (((this.Dob.Month == 12) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 01) && (this.Dob.Day < 05)))
            {
                return $"The Chinese sign is Rat";
            }
            else if (((this.Dob.Month == 01) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 02) && (this.Dob.Day <= 03)))
            {
                return $"The Chinese sign is Ox";
            }
            else if (((this.Dob.Month == 02) && (this.Dob.Day >= 04)) || ((this.Dob.Month == 03) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Tiger";
            }
            else if (((this.Dob.Month == 03) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 04) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Rabbit";
            }
            else if (((this.Dob.Month == 04) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 05) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Dragon";
            }
            else if (((this.Dob.Month == 05) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 06) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Snake";
            }
            else if (((this.Dob.Month == 06) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 07) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Horse";
            }
            else if (((this.Dob.Month == 07) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 08) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Goat";
            }
            else if (((this.Dob.Month == 08) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 09) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Monkey";
            }
            else if (((this.Dob.Month == 09) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 10) && (this.Dob.Day <= 05)))
            {
                return $"The Chinese sign is Rooster";
            }
            else if (((this.Dob.Month == 10) && (this.Dob.Day >= 06)) || ((this.Dob.Month == 11) && (this.Dob.Day <= 06)))
            {
                return $"The Chinese sign is Dog";
            }
            else
            {
                return $"The Chinese sign is Pig";
            }

        }
        public string BirthdayCheck()
        {
            if ((this.Dob.Month == DateTime.Today.Month) && (this.Dob.Day == DateTime.Today.Day))
            {
                return $"Happy birthday {this.firstName}";
            }
            else
                return "It's not your birthday";
        }
        public string ScreenName()
        {
            return $"{this.firstName}{this.lastName}{this.Dob.Month}{this.Dob.Day}{this.Dob.Year}";
        }
        public void validateDOB()
        {
            if (this.age < 0)
            {
                throw (new InvalidAgeException("Age is invalid"));
            }
           
        }
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)
            {

            }
        }
        public void DOBCheck()
        {
            if (this.age > 125)
            {
                throw (new UnidealAgeException("Age is invalid"));
            }
          
        }
        public class UnidealAgeException : Exception
        {
            public UnidealAgeException(string message) : base(message)
            {

            }
        }
        public void validateEmail()
        {
            if (this.emailAdd.Contains("@mydomain.com"))
            {
                
            }
            else
            {
                throw (new InvalidEmailException("Email is invalid"));
            }
            
        }
        public class InvalidEmailException : Exception
        {
            public InvalidEmailException(string message) : base(message)
            {

            }
        }
    }
    class Persontest
    {
        public static void Main()
        {
            Person p = new Person("Abc", "Xyz", "abc@mydomain.om", new DateTime(1885, 08, 10));
            Console.WriteLine(p.ScreenName());
            Console.WriteLine(p.adult());
            try
            {
                p.validateDOB();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                p.validateEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                p.DOBCheck();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(p.Sunsign());
            Console.WriteLine(p.ChineseSign());
            Console.WriteLine(p.BirthdayCheck());

        }
    }
}
