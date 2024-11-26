using System;

namespace SpecialistProjekt.Models
{
    public class Specialist
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public string Szolgaltatas { get; set; }
        public string EducationLevel { get; set; }
        public int Ratenumber { get; set; }

        public Specialist(string firstName, string lastName, DateTime birthsDay, string szolgaltatas, string educationLevel,int ratenumber)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            Szolgaltatas = szolgaltatas;
            EducationLevel = educationLevel;
            Ratenumber = ratenumber;
        }

        public Specialist()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            Szolgaltatas = string.Empty;
            EducationLevel = string.Empty;
            Ratenumber = 10;
        }
    }
}