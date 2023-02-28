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
    /// Interaction logic for OfficeManager.xaml
    /// </summary>
    public partial class OfficeManager : Window
    {
        public OfficeManager()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            String query = "Select * from Employee";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader Reader = command.ExecuteReader();

            listOfficeManager1.Items.Add("Available Users");
            listOfficeManager1.Items.Add("Employee Number \t\t Username \t\t Employee Type");
            while (Reader.Read())
            {

                String currentemployeeNumber = Reader["employeeNumber"].ToString();
                String Username = Reader["Username"].ToString();//assigning 
                String EmpType = Reader["EmpType"].ToString();

                listOfficeManager1.Items.Add(currentemployeeNumber + "\t\t" + Username + "\t\t" + EmpType);
                    //Display message for successful log in
                    MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                    //go to office manager window here 

            }
        }

        private void btnDash_Click(object sender, RoutedEventArgs e)
        {
            new DashBoard().Show();
        }
    }
}
