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
    /// Interaction logic for ReportSheet1.xaml
    /// </summary>
    public partial class ReportSheet1 : Window
    {
        public ReportSheet1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }

        private void btnVehicleStatus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //retrievce from vehicle status here
                String query = "Select * from VehicleStatus";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
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
                String query = "Select * from appointmentList(employeeNumber,appointmentDate,nextAppointDate) where employeeNumber =" + SignIn.currentemployeeNumber + "";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();
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

        }

        private void btnServiceReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSpecificReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTripReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCompleteTrip_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTimeSheet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

