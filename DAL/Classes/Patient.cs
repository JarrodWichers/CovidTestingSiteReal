using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Patient
    {
        // DdW: I we must just check if all the variables I put in here are in the Database
        public int PatientID { get; set; }        
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ContactNum { get; set; }
        public string Email { get; set; }        
        public string Gender { get; set; }
        public string IdentityNo { get; set; }
        public string DateOfBirth { get; set; }
        public int BedID { get; set; }
        public int NextOfKinID { get; set; }

        // KK: Can calculate using DoB
        //public int Age { get; set; }
        // KK: To be added to DB
        //public string DateAdmitted { get; set; }
        // KK: Unnecessary, fields available in other entities linked to patient
        //// Drugs prescribed might go into the drug chart.  Wil 
        //public string DrugsPrescribed { get; set; }
        //public int QTY { get; set; }
        //public int BloodPreasure { get; set; }
        //public int HeartRate { get; set; }

        //Will fix the error
        // KK: Dont need to instantiate class if it's done in the PL 
        //public PatientClass(int patientNumber, string name, string surname, char gender, int id, string dob, int age, string dateAdmitted, int roomNumber, int bedNumber, string drugsPrescribed, int qty, int bloodPreasure, int heartRate)
        //{
        //    PatientNumber = patientNumber;
        //    Name = name;
        //    Surname = surname;
        //    Gender = gender;
        //    ID = id;
        //    DOB = dob;
        //    Age = age;
        //    DateAdmitted = dateAdmitted;
        //    RoomNumber = roomNumber;
        //    BedNumber = bedNumber;
        //    DrugsPrescribed = drugsPrescribed;
        //    QTY = qty;
        //    BloodPreasure = bloodPreasure;
        //    HeartRate = heartRate;

        //}
    }
}

