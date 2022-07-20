using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class MovieStar
    {
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private string sex;
        private string nationality;
        public MovieStar(string name, string surname, DateTime dateOfBirth, string sex, string nationality)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            Nationality = nationality;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
    }
}
