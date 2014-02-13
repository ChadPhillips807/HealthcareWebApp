using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using NotifyDoctor;
using System.Data;

namespace HealthcareAppointmentWebApp
{
    public partial class AppointmentDisplayWebForm : System.Web.UI.Page
    {
        // TODO: Add WHERE clause to the GridView's query to retrieve
        // only appointments for today.
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Notifier notifier = new Notifier("+14258905535", "Test");




            //// Appointments list will feed a repeater control
            //// to create an appointments table.
            //IQueryable appointments;

            //AppointmentRetriever apps = new AppointmentRetriever();

            //appointments = apps.GetAppointments();

            //AppointmentRepeater.DataSource = appointments;
            //AppointmentRepeater.DataBind();
            
            // TODO: 
            // 2. Need to add a checked in field and have a variable
            // that changes the Check In link to say just Here 
            // 
            // 2. The first row of the table should have "Check In"
            // links. If the user clicks the check in link have
            // the checked in value in the DB changed from 0 to 1.
            // Reload the page to show this change.
            
        }

        //protected void AppointmentDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        //{
        //    // Appointments list will feed a repeater control
        //    // to create an appointments table.
        //    IQueryable appointments;

        //    AppointmentRetriever apps = new AppointmentRetriever();

        //    appointments = apps.GetAppointments();

        //    e.Result = appointments;            
        //}

        //protected void AppointmentDataSource_Updating(object sender, LinqDataSourceUpdateEventArgs e)
        //{
        //    // Check if the Status field's value is true or false.
        //    ////If true then change the edit link to readonly
        //    ////If false, give alert saying nothing changed.
        //    Appointment originalAppointment = (Appointment)e.OriginalObject;
        //    Appointment newAppointment = (Appointment)e.NewObject;

        //    if (newAppointment.Status == true)
        //    {
        //        CommandField cmdfld = new CommandField();
        //        cmdfld.EditText = "Here";
        //    }
        //}

        protected void AppointmentsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Update the row here
            if (e.CommandName == "Update")
            {
                // Maybe try to update row here.
                // Clicking LinkButton takes us here.

                int index = AppointmentsGridView.EditIndex;

                GridViewRow row = AppointmentsGridView.Rows[index];

                row.Cells[0].Text = "Here";
            }
            

        }

        protected void CheckInLinkButton_Click(object sender, EventArgs e)
        {
            // Check to see if Data is in GridView
            if (AppointmentsGridView.DataKeys.Count > 0)
	        {
                LinkButton linkbutton = sender as LinkButton;

                GridViewRow row = linkbutton.NamingContainer as GridViewRow;

                string name = row.Cells[3].Text;



	        }
            
//            if (GridView.DataKeys.Count > 0)
//{
//    // Your code accessing the 1st element in the collection goes here.
//    // Remember that DataKeys[0] returns the first element (count >= 1).

//    // This is safe, since Count is bigger than 0, so there is at least one item. 
//    GridView.DataKeys[0].Value.ToString()
//    // Might still throw an exception, since you're not sure if count = 2.
//    GridView.DataKeys[1].Value.ToString()
//}

            // Maybe try to update row here.
            // Clicking LinkButton takes us here.

            //int index = AppointmentsGridView.SelectedIndex;

            //GridViewRow row = AppointmentsGridView.Rows[index];

            //row.Cells[0].Text = "Here";
            

        }

        protected void AppointmentsGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string face = "";

            int index = AppointmentsGridView.EditIndex;

                // Maybe try to update row here.
                // Clicking LinkButton takes us here.

                //int index = AppointmentsGridView.EditIndex;

                //GridViewRow row = AppointmentsGridView.Rows[index];

                //row.Cells[0].Text = "Here";
            
        }

        protected void AppointmentsGridView_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            //Page the doctor here
            DateTime appDate = DateTime.Now;




        }

        protected void AppointmentsGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            // Row is the row that was updated.
            GridViewRow row = AppointmentsGridView.Rows[e.RowIndex];

            // isCheckedIn is the Boolean value field Status.
            bool isCheckedIn = Convert.ToBoolean(e.NewValues[1].ToString());

            //AppointmentsGridView.Columns[0].Visible = false;
            row.Cells[0].Visible = false;
            

                    
        }

        protected void AppointmentsGridView_RowCreated(object sender, GridViewRowEventArgs e)
        {
            // DataItemIndex -1 = GridView Header
            var index = e.Row.DataItemIndex;

            if (index >= 0)
            {
                
            }

            
        }
    }
}