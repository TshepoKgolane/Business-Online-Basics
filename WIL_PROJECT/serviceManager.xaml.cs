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
    /// Interaction logic for serviceManager.xaml
    /// </summary>
    public partial class serviceManager : Window
    {
        public serviceManager()
        {
            InitializeComponent();
            listServiceMan.Items.Add("employee Number\t Appointment Date");
        }
        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(3);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
                try
            {
                connection.Open();
                //insert to database here
                String query = "insert Into appointmentList(employeeNumber,appointmentDate)" +
                               "VALUES(" + SignIn.currentemployeeNumber + ",'" + dtAppointment.SelectedDate + ")";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                MessageBox.Show("Successfully added appointment", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                listServiceMan.Items.Add(SignIn.currentemployeeNumber +"\t"+ dtAppointment.SelectedDate);
                this.Visibility = Visibility.Hidden;

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
    }
}
