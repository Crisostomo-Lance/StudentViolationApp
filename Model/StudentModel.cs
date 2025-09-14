using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentViolationApp.Model
{
    public class StudentModel
    {

        // Private fields (variables)
        private string student_ID;
        private string last_Name;
        private string first_Name;
        private string middle_Name;
        private char gender;
        private int age;
        private DateTime birthdate;
        private string email;
        private string phone_Number;
        private string program_Code;
        private string program;
        private int year_Level;
        private string section;
        private string offense_Type;
        private int offense_Count;

        // Public properties (getters and setters) for controlled access

        [DisplayName("Student ID")]
        [Required(ErrorMessage = "Student ID is required.")]
        public string Student_ID
        {
            get { return student_ID; }
            set { student_ID = value; }
        }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string Last_Name
        {
            get { return last_Name; }
            set { last_Name = value; }
        }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string First_Name
        {
            get { return first_Name; }
            set { first_Name = value; }
        }

        [DisplayName("Middle Name")]
        public string Middle_Name
        {
            get { return middle_Name; }
            set { middle_Name = value; }
        }

        [DisplayName("Gender")]
        [Required (ErrorMessage = "Gender is required.")]
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required.")]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        [DisplayName("Birthdate")]
        [Required(ErrorMessage = "Birthdate is required.")]
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string Phone_Number
        {
            get { return phone_Number; }
            set { phone_Number = value; }
        }

        [DisplayName("Program Code")]
        [Required(ErrorMessage = "Program Code is required.")]
        public string Program_Code
        {
            get { return program_Code; }
            set { program_Code = value; }
        }

        [DisplayName("Program")]
        [Required(ErrorMessage = "Program is required.")]
        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        [DisplayName("Year Level")]
        [Required(ErrorMessage = "Year Level is required.")]
        public int Year_Level
        {
            get { return year_Level; }
            set { year_Level = value; }
        }

        [DisplayName("Section")]
        [Required(ErrorMessage = "Section is required.")]
        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        [DisplayName("Offense Type")]
        [Required(ErrorMessage = "Offense Type is required.")]
        public string Offense_Type
        {
            get { return offense_Type; }
            set { offense_Type = value; }
        }

        [DisplayName("Offense Count")]
        [Required(ErrorMessage = "Offense Count is required.")]
        public int Offense_Count
        {
            get { return offense_Count; }
            set { offense_Count = value; }
        }

        // Constructor to initialize a new Student object
        public StudentModel(string studentID, string lastName, string firstName, string middleName, char gender, int age, DateTime birthdate, string email, string phoneNumber, string programCode, string program, int yearLevel, string section, string offenseType, int offenseCount)
        {
            student_ID = studentID;
            last_Name = lastName;
            first_Name = firstName;
            middle_Name = middleName;
            gender = gender;
            age = age;
            birthdate = birthdate;
            email = email;
            phone_Number = phoneNumber;
            program_Code = programCode;
            program = program;
            year_Level = yearLevel;
            section = section;
            offense_Type = offenseType;
            offense_Count = offenseCount;
        }
    }



}
