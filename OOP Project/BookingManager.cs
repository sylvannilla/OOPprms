using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class BookingManager : BookingBase
    {
        private readonly string connectionString =
            "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
            "Port=19631;" +
            "Database=defaultdb;" +
            "User ID=avnadmin;" +
            "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
            "SslMode=Required;";

        public void InsertBooking(DateTime appointmentDateTime, DateTime submissionDateTime, string patientName,
                                  string gender, string age, string dateOfBirth, string phoneNumber, string email,
                                  string address, string currentMedication, string additionalNotes)
        {
            using var con = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(@" INSERT INTO oop_project.booking 
                                            (appointment_datetime, submission_datetime, patient_name, gender, age, date_of_birth, phone_number, email, address, current_medication, additional_notes, status)
                                            VALUES 
                                            (@appointment_datetime, @submission_datetime, @patientname, @gender, @age, @dateofbirth, @phonenumber, @email, @address, @current_medication, @additional_notes, @status)", con);

            cmd.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);
            cmd.Parameters.AddWithValue("@submission_datetime", submissionDateTime);
            cmd.Parameters.AddWithValue("@patientname", patientName);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@phonenumber", phoneNumber);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@current_medication", currentMedication);
            cmd.Parameters.AddWithValue("@additional_notes", additionalNotes);
            cmd.Parameters.AddWithValue("@status", "Pending");

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
