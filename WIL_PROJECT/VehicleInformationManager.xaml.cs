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
    /// Interaction logic for VehicleInformationManager.xaml
    /// </summary>
    public partial class VehicleInformationManager : Window
    {
        public VehicleInformationManager()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //appointmentList
            try
            {
                connection.Open();
                //insert to database here
                String query = "insert Into appointmentList(employeeNumber,appointmentDate)" +
                               "VALUES(" + SignIn.currentemployeeNumber + ",'" + dtnextService.SelectedDate + "')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                MessageBox.Show("Successfully added appointment", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                listVehicles.Items.Add("Employee Number" + "\t" + "Next Service date");
                listVehicles.Items.Add(SignIn.currentemployeeNumber + "\t" + dtnextService.SelectedDate);

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }
    }
}
