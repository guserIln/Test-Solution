using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutionProject
{
    public class Patient
    {
        private String Id { get; set; }
        private String familyName { get; set; }
        private String name { get; set; }
        private String patr { get; set; }
        private DateTime birthDate { get; set; }
        private String phone { get; set; }
        public Patient(String Id, String familyName, String name, String patr, DateTime birthDate, String phone) { 
            this.Id = Id;
            this.name = name;
            this.familyName = familyName;
            this.patr = patr;
            this.birthDate = birthDate;
            this.phone = phone;

        }
        public String getId()
        {
            return Id;
        }
        public String getFamilyName()
        {
            return familyName;
        }
        public String getName()
        {
            return name;
        }
        public String getPatr()
        {
            return patr;
        }
        public DateTime getBirthDate()
        {
            return birthDate;
        }
        public String getPhone()
        {
            return phone;
        }
    }
}
