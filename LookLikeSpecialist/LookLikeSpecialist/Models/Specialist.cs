using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LookLikeSpecialist.Models
{
    public class Specialist
    {
        //A Specialista adatai
        public string Vnev { get; set; }
        public string Kernev { get; set; }
        public DateTime Szuldatum { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }

        public Specialist(string vnev, string knev, DateTime szuldatum, string email, string companyname)
        {//Konstruktor
            Vnev = vnev;
            Kernev = knev;
            Szuldatum = szuldatum;
            Email = email;
            CompanyName = companyname;

        }
        //Passwordok eltávolítva
        public Specialist()
        {
            Vnev = string.Empty;
            Kernev = string.Empty;
            Szuldatum = new DateTime();
            Email = string.Empty;
            CompanyName = string.Empty;
        }
    }
}