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
    /// Interaction logic for TripManager.xaml
    /// </summary>
    public partial class TripManager : Window
    {
        public TripManager()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //btn save
            connection.Open();
            try
            {
                //retrievce from vehicle status here
                String query = "insert Into TripManager(employeeNumber,scheduledTrip,fuelUsage,incidents)" +
                        "VALUES(" + SignIn.currentemployeeNumber + ",'" + Convert.ToDateTime(dtscheduleTrip.SelectedDate) + "','" + txtFuelUsed + "','" + txtIncidentsPerTrip + "')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                MessageBox.Show("Successfully Captured Trip ", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }
    }
}
