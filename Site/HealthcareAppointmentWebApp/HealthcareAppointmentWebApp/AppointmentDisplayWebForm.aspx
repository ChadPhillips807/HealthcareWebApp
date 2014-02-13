<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppointmentDisplayWebForm.aspx.cs" Inherits="HealthcareAppointmentWebApp.AppointmentDisplayWebForm" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Doctor's Appointments</title>
    <link type="text/css" rel="stylesheet" href="Styles/styles.css"/>
</head>
<body>
    <form id="AppointmentForm" runat="server">
    <div id="table_container">
        <div>            
            <h3><% =DateTime.Now.ToShortDateString() %></h3>
            <h2>Today's Appointments</h2>   
        </div>

        <asp:GridView ID="AppointmentsGridView" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="AppointmentId" DataSourceID="AppointmentNotCheckedInDataSource" OnRowCommand="AppointmentsGridView_RowCommand" 
            OnRowEditing="AppointmentsGridView_RowEditing" OnRowUpdated="AppointmentsGridView_RowUpdated" 
            OnRowUpdating="AppointmentsGridView_RowUpdating" OnRowCreated="AppointmentsGridView_RowCreated">

            <Columns>
                <asp:CommandField ShowEditButton="True" EditText="Check In" />
                <asp:BoundField DataField="DateTime" HeaderText="DateTime" SortExpression="DateTime" ReadOnly="True" />
                <asp:TemplateField HeaderText="Patient" SortExpression="Patient.Contact">
                    <ItemTemplate>
                        <%#Eval("Patient.Contact.LastName") %>, <%#Eval("Patient.Contact.FirstName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Doctor" SortExpression="Doctor.Contact">
                    <ItemTemplate>
                        <%#Eval("Doctor.Contact.LastName") %>, <%#Eval("Doctor.Contact.FirstName") %>
                    </ItemTemplate>
                </asp:TemplateField>               
                <asp:CheckBoxField DataField="Status" HeaderText="Checked In?" SortExpression="Status" />               
            </Columns>

        </asp:GridView>

        <asp:LinqDataSource ID="AppointmentNotCheckedInDataSource" runat="server" 
            ContextTypeName="DataAccess.HealthcareDBDataContext"
            EnableUpdate="True" EntityTypeName="" TableName="Appointments" Where="Status == @Status">
            <WhereParameters>
                <asp:Parameter DefaultValue="false" Name="Status" Type="Boolean" />
            </WhereParameters>
        </asp:LinqDataSource>
        
        <br />
        <h2>Checked In</h2>
        <asp:GridView ID="AppointmentCheckedinGridView" runat="server" DataSourceID="AppointmentCheckedInDataSource"
            AutoGenerateColumns="False" DataKeyNames="AppointmentId">
            <Columns>

                <asp:BoundField DataField="DateTime" HeaderText="DateTime" SortExpression="DateTime" />

                <asp:TemplateField HeaderText="Patient" SortExpression="Patient.Contact">
                    <ItemTemplate>
                        <%#Eval("Patient.Contact.LastName") %>, <%#Eval("Patient.Contact.FirstName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Doctor" SortExpression="Doctor.Contact">
                    <ItemTemplate>
                        <%#Eval("Doctor.Contact.LastName") %>, <%#Eval("Doctor.Contact.FirstName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                
                <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="AppointmentCheckedInDataSource" runat="server" ContextTypeName="DataAccess.HealthcareDBDataContext" EntityTypeName="" TableName="Appointments" Where="Status == @Status">
            <WhereParameters>
                <asp:Parameter DefaultValue="true" Name="Status" Type="Boolean" />
            </WhereParameters>
        </asp:LinqDataSource>
        
    </div>
    </form>
</body>
</html>
