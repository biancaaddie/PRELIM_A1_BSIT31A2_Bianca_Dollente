using System;

namespace PRELIM_A1_BSIT31A2_Bianca_Dollente.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        private string firstName;
        private string lastName;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; private set; } = Gender.Unknown;

        public string FullName => $"{Title} {firstName} {lastName}";
        public int Age => DateTime.Now.Year - Birthday.Year -
            (DateTime.Now.DayOfYear < Birthday.DayOfYear ? 1 : 0);

        public Student()
        {
            Title = "Mr./Ms.";
            firstName = "First";
            lastName = "Last";
            Course = "BSIT";
            Section = "31A1";
            Birthday = new DateTime(2000, 1, 1);
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SetFirstName(string fname) => firstName = fname;
        public void SetLastName(string lname) => lastName = lname;
        public void SetGender(Gender gender) => Gender = gender;
    }
}

