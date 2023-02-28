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
    /// Interaction logic for ServiceSheet.xaml
    /// </summary>
    public partial class ServiceSheet : Window
    {
        public ServiceSheet()
        {
            InitializeComponent();
        }
            
            SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            try
            {
                connection.Open();
                //insert to database here
                String query = "insert Into serviceSheet(employeeNumber,scheduledAppointmentTimes,ServiceType,appointmentDate,vehicleNumber,procedureCode,serviceCost)" +
                               "VALUES(" + SignIn.currentemployeeNumber + "," +Convert.ToInt32(txtappointmentTimes.Text) +",'" + txtserviceType.Text + "','" + dtAppointments.SelectedDate + "','" + txtvehicleNumber.Text + "','" + txtprocedureCode.Text + "','" + txtprocedureCosts.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                MessageBox.Show("Added Service to database", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Visibility = Visibility.Hidden;
                new DashBoard().Show();

            }
            catch (Exception fr)
            {
                MessageBox.Show(fr.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(3);
        }
    }
}
