using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WIL_PROJECT
{
    /// <summary>
    /// Interaction logic for ReportSheet.xaml
    /// </summary>
    public partial class ReportSheet : Window
    {
        public ReportSheet()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void btnVehicleStatus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //retrievce from vehicle status here
                String query = "Select * from VehicleStatus";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
                listreport.Items.Clear();
                listreport.Items.Add("employee Number\tvehicle Number\tManufacturer\tEngine Size\tNext Odometer\tVehicle Type\tOdometer Reader");

                while (Reader.Read())
                {
                    String currentemployeeNumber = Reader["employeeNumber"].ToString();
                    String vehicleNumb = Reader["vehicleNumb"].ToString();
                    String Manufacturer = Reader["Manufacturer"].ToString();
                    String EngineSize = Reader["EngineSize"].ToString();
                    String NextOdometer = Reader["NextOdometer"].ToString();
                    String VehicleType = Reader["VehicleType"].ToString();
                    String OdometerReader = Reader["OdometerReader"].ToString();//assigning 
                                                                                //
                    listreport.Items.Add(currentemployeeNumber + "\t\t" + vehicleNumb + "\t\t" + Manufacturer + "\t\t" + EngineSize + "\t\t" + NextOdometer + "\t\t" + VehicleType + "\t\t" + OdometerReader);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void btnAppointment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //retrievce from vehicle status here
                String query = "Select * from appointmentList where employeeNumber =" + SignIn.currentemployeeNumber + "";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
                listreport.Items.Clear();
                listreport.Items.Add("employee Number\t Appointment Date");

                while (Reader.Read())
                {
                    String employeeNumber = Reader["employeeNumber"].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(Reader["appointmentDate"].ToString());
                    //assigning 
                    //
                    listreport.Items.Add(employeeNumber + "\t\t" + appointmentDate);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //retrievce from vehicle status here
                String query = "Select * from serviceSheet where employeeNumber =" + SignIn.currentemployeeNumber + "";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
                listreport.Items.Clear();
                listreport.Items.Add("employee Number\t scheduledAppointmentTimes\tServiceType\tappointmentDate\tvehicleNumber\tprocedureCode\tserviceCost");

                while (Reader.Read())
                {
                    String employeeNumber = Reader["employeeNumber"].ToString();
                    int appointmenttimes = Convert.ToInt32(Reader["scheduledAppointmentTimes"].ToString());
                    String ServiceType = Reader["ServiceType"].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(Reader["appointmentDate"].ToString());
                    String vehicleNumber = Reader["vehicleNumber"].ToString();
                    String procedureCode = Reader["procedureCode"].ToString();
                    int serviceCost = Convert.ToInt32(Reader["serviceCost"].ToString());
                    //assigning 
                    listreport.Items.Add(employeeNumber + "\t\t" + appointmenttimes + "\t\t" + ServiceType + "\t\t" + appointmentDate + "\t\t" + vehicleNumber + "\t" + procedureCode + "\t" + serviceCost);

                }
                if (listreport.Items.Count < 1)
                {
                    listreport.Items.Add("No Data");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnServiceReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSpecificReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTripReport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                //retrievce from vehicle status here
                String query = "Select * from TripSheet where currentemployeeNumber =" + SignIn.currentemployeeNumber;

                //retrievce from vehicle status here


                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
                listreport.Items.Clear();
                listreport.Items.Add("employee Number\tDestination\ttripHours\tkilometers");

                while (Reader.Read())
                {
                    String employeeNumber = Reader["employeeNumber"].ToString();
                    String Destination = Reader["Destination"].ToString();
                    int tripHours = Convert.ToInt32(Reader["tripHours"].ToString());
                    int kilometers = Convert.ToInt32(Reader["kilometers"].ToString());
                    ;
                    //assigning 
                    listreport.Items.Add(employeeNumber + "\t\t" + Destination + "\t\t" + tripHours + "\t\t" + kilometers);

                }
                if (listreport.Items.Count < 1)
                {
                    listreport.Items.Add("No Data");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnCompleteTrip_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                //retrievce from vehicle status here
                String query = "Select * from TripManager where currentemployeeNumber =" + SignIn.currentemployeeNumber;

                //retrievce from vehicle status here


                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
                listreport.Items.Clear();
                listreport.Items.Add("employee Number\tscheduled Trip\tfuel Usage\tincidents");

                while (Reader.Read())
                {
                    String employeeNumber = Reader["employeeNumber"].ToString();
                    DateTime scheduledTrip = Convert.ToDateTime(Reader["scheduledTrip"].ToString());
                    String fuelUsage = Reader["fuelUsage"].ToString();
                    String incidents = Reader["incidents"].ToString();
                    //assigning 
                    listreport.Items.Add(employeeNumber + "\t\t" + scheduledTrip + "\t\t" + fuelUsage + "\t\t" + incidents);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnTimeSheet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
