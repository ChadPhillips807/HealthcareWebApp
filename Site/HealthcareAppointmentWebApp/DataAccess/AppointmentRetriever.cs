using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class AppointmentRetriever
    {
        // The DataContext Object is used to connect to the HealthcareDB database.
        private HealthcareDBDataContext healthcareDBContext;
        private AppointmentData singleAppointment;
        //private List<AppointmentData> TodaysAppointments;

        public AppointmentRetriever()
        {
           
        }

        public IQueryable GetAppointments()
        {
            try
            {
                healthcareDBContext = new HealthcareDBDataContext();

                // Instantiate the appointment lists now for use in loop
                // singleAppointment will be reused
                
                List<AppointmentData> todaysAppointments = new List<AppointmentData>();

                // appointments will hold a query that contains all appointments for today.
                // need to get the doctor name patient name and the doctors number.
                var appointments = from a in healthcareDBContext.Appointments
                                   where a.DateTime.Date == DateTime.Today
                                   select new
                                   {
                                       appointmentId = a.AppointmentId,
                                       appointmentDate = a.DateTime,
                                       patientName = a.Patient.Contact.FirstName + " " + a.Patient.Contact.LastName,
                                       doctorName = a.Doctor.Contact.FirstName + " " + a.Doctor.Contact.LastName,
                                       checkedIn = a.Status
                                   };

                //// Loop through appointments and add them to the
                //// List<AppointmentData> TodaysAppointments;
                //foreach (var appointment in appointments)
                //{
                //    singleAppointment = new AppointmentData();

                //    singleAppointment.AppointmentId = appointment.appointmentId;
                //    singleAppointment.AppointmentDateTime = appointment.appointmentDate;
                //    singleAppointment.PatientName = appointment.patientName;
                //    singleAppointment.DoctorName = appointment.doctorName;

                //    if (!appointment.checkedIn)
                //    {
                //        singleAppointment.CheckedIn = "<a href=\"#\">Check In</a>";
                //    }
                //    else
                //    {
                //        singleAppointment.CheckedIn = "CHECKED IN";
                //    }

                //    //singleAppointment.CheckedIn = appointment.checkedIn;

                //    todaysAppointments.Add(singleAppointment);
                    
                //}

                //return todaysAppointments;
                return appointments;
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
    }
}
