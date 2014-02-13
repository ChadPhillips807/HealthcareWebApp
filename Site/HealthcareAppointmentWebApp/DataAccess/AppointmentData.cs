using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    /// <summary>
    /// This class represents data for one appointment.
    /// </summary>
    public class AppointmentData
    {
        // Using AppointmentId to easily get
        //back to row in the case of the check in
        public int AppointmentId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string CheckedIn { get; set; }
    }
}
