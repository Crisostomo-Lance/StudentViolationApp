using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentViolationApp.Model
{
    public class DisciplineOfficerModel
    {
        
        // Private fields (variables)
        private string officer_ID;
        private string last_Name;
        private string middle_Name;
        private string first_Name;
        private string email_Address;
        private string login_Username;
        private string login_Password;
        private string department;

        // Public properties for controlled access (getters and setters)
        [DisplayName("ID")]
        public string Officer_ID
        {
            get { return officer_ID; }
            set { officer_ID = value; }
        }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string Last_Name
        {
            get { return last_Name; }
            set { last_Name = value; }
        }

        [DisplayName("Middle Name")]
        public string Middle_Name
        {
            get { return middle_Name; }
            set { middle_Name = value; }
        }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string First_Name
        {
            get { return first_Name; }
            set { first_Name = value; }
        }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email Address is required.")]
        public string Email_Address
        {
            get { return email_Address; }
            set { email_Address = value; }
        }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required.")]
        public string Login_Username
        {
            get { return login_Username; }
            set { login_Username = value; }
        }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Login_Password
        {
            get { return login_Password; }
            set { login_Password = value; }
        }

        [DisplayName("Department")]
        [Required(ErrorMessage = "Department is required.")]
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        // Constructor to initialize a new DisciplineOfficer object
        public DisciplineOfficerModel(string officerID, string lastName, string firstName, string middleName, string emailAddress, string loginUsername, string loginPassword, string department)
        {
            officer_ID = officerID;
            last_Name = lastName;
            first_Name = firstName;
            middle_Name = middleName;
            email_Address = emailAddress;
            login_Username = loginUsername;
            login_Password = loginPassword;
            department = department;
        }


    }
}
