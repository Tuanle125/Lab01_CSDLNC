using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3._1_ADB2023
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime YearOfAdmission { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public Student(string id, string firstname, string lastname, DateTime yearofadmission, DateTime dateofbirth, int age)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            YearOfAdmission = yearofadmission;
            DateOfBirth = dateofbirth;
            Age = age; 
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", Id, FirstName, LastName, YearOfAdmission, DateOfBirth, Age);
        }
    }
}
