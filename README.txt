Description:
 This application is for a healthcare organization's appointments. In the  Appointment web application the user can view the days appointments, as  well as their associated patients and doctors. Users can also check each  patient in sending the doctor a message.

User Reqs:

 1. Need list of all of todays appointments.
 2. Must be able to notify Dr. of patients arrival and   
   readiness.

Tools:

 Use C#, SQL, & ASP.NET; 
 SMS svc such as Twillio(Not sure for what yet. Maybe to  
 notify the Dr.)

DB:

 Contacts: ContactId(identity), FirstName, LastName 
 Patients: PatientId(identity), ContactId
 Doctors: DoctorId(identity), ContactId
 PhoneNumbers: PhoneId(identity), ContactId, PhoneNum
 Appointments: AppointmentId(identity), PatientId, DoctorId,  
        Date/Time, Status(bit)

Web Interface:

 Present all appointments for the day. Have a patient checkin  
 feature. Should have it so the appointments in the database  
 are updated to todays date and have the web interface only  
 show todays list of patients.

Notifications:

 When a user clicks the "Check In" link, the relevant doctor  
 is sent a text msg advising them of the patients arrival.  
 (OPTIONAL)Have the link pop up a textblock for the user to enter a 
 msg to be sent to the Dr. Figure out Twillio or another similar 
 products.

Bonus:

1. Allow the check-in user to send a message (such as “fifteen 
minutes early but doesn’t mind waiting”) along with the check-in 
notification. 

2. Use Twitter Bootstrap (or similar) to implement a responsive 
design that scales down to tablet and smartphone viewport sizes.

3. Ensure that if multiple users are viewing the check-in screen 
simultaneously that check-ins by one person are seen by the other(s) 
in real-time (via Ajax polling, web sockets, or other means).