using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentViolationApp.Model
{
    public class ViolationModel
    {
        
        // Private fields (variables)
        private string violation_ID;
        private string violation_Type;
        private string violation_Desc;
        private string severity;
        private string sanction;
        private DateTime date_Committed;
        private TimeSpan time_Committed;
        private string reported_By;
        private string violation_Status;

        // Public properties for controlled access (getters and setters)
        public string Violation_ID
        {
            get { return violation_ID; }
            set { violation_ID = value; }
        }

        public string Violation_Type
        {
            get { return violation_Type; }
            set { violation_Type = value; }
        }

        public string Violation_Desc
        {
            get { return violation_Desc; }
            set { violation_Desc = value; }
        }

        public string Severity
        {
            get { return severity; }
            set { severity = value; }
        }

        public string Sanction
        {
            get { return sanction; }
            set { sanction = value; }
        }

        public DateTime Date_Committed
        {
            get { return date_Committed; }
            set { date_Committed = value; }
        }

        public TimeSpan Time_Committed
        {
            get { return time_Committed; }
            set { time_Committed = value; }
        }

        public string Reported_By
        {
            get { return reported_By; }
            set { reported_By = value; }
        }

        public string Violation_Status
        {
            get { return violation_Status; }
            set { violation_Status = value; }
        }

        // Constructor to initialize a new Violation object
        public ViolationModel(string violationID, string violationType, string violationDesc, string severity, string sanction, DateTime dateCommitted, TimeSpan timeCommitted, string reportedBy, string violationStatus)
        {
            violation_ID = violationID;
            violation_Type = violationType;
            violation_Desc = violationDesc;
            severity = severity;
            sanction = sanction;
            date_Committed = dateCommitted;
            time_Committed = timeCommitted;
            reported_By = reportedBy;
            violation_Status = violationStatus;
        }

        // Method to display violation details

    }

}
