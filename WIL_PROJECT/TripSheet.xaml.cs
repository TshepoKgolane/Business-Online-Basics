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
    /// Interaction logic for TripSheet.xaml
    /// </summary>
    public partial class TripSheet : Window
    {
        public TripSheet()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(SignIn.connString);

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                //insert to database here
                String query = "insert Into TripSheet(employeeNumber,Destination,tripHours,kilometers)" +
                               "VALUES(" + SignIn.currentemployeeNumber + ",'" + txttripDestination.Text + "'," + txttripTime.Text + "," + txttripKilometers.Text+ ")";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                MessageBox.Show("Added Trip to database", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Visibility = Visibility.Hidden;
                new DashBoard().Show();

            }
            catch(Exception fr)
            {
                MessageBox.Show(fr.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
