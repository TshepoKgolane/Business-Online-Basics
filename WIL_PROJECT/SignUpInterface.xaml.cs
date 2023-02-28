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
    /// Interaction logic for SignUpInterface.xaml
    /// </summary>
    public partial class SignUpInterface : Window
    {
        public SignUpInterface()
        {
            InitializeComponent();
            cmbEmployee1.Items.Add("Office Manager");
            cmbEmployee1.Items.Add("vehicle Information Manager");
            cmbEmployee1.Items.Add("Trip Manager");
            cmbEmployee1.Items.Add("service Manager");
            cmbEmployee1.Items.Add("timesheet Manager");
            cmbEmployee1.Items.Add("Driver");
        }

        
        SqlConnection connection = new SqlConnection(SignIn.connString);

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            SignIn objsignIn = new SignIn();
            this.Visibility = Visibility.Hidden;
            objsignIn.Show();
        }


        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                connection.Open();
                //ching which type of user is signing up
                if (cmbEmployee1.SelectedItem.Equals("Office Manager"))
                {

                    String query = "insert Into Employee(Username,EmpType,EmpPassword)" +
                        "VALUES('" + txtuserName.Text + "','" + "OfficeManager" + "','" + Hashing.Encrypt(txtpassword.Text) + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Welcome! " + txtuserName.Text + "", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                }
                else if (cmbEmployee1.SelectedItem.Equals("vehicle Information Manager"))
                {
                    String query = "insert Into Employee(Username,EmpType,EmpPassword)" +
                        "VALUES('" + txtuserName.Text + "','" + "vehicleInformationManager" + "','" + Hashing.Encrypt(txtpassword.Text) + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Welcome! " + txtuserName.Text + "", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    SignIn objsign = new SignIn();
                    this.Visibility = Visibility.Hidden;
                    objsign.Show();
                }
                else if (cmbEmployee1.SelectedItem.Equals("Trip Manager"))
                {
                    String query = "insert Into Employee(Username,EmpType,EmpPassword)" +
                         "VALUES('" + txtuserName.Text + "','" + "TripManager" + "','" + Hashing.Encrypt(txtpassword.Text) + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Welcome! " + txtuserName.Text + "", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    SignIn objsign = new SignIn();
                    this.Visibility = Visibility.Hidden;
                    objsign.Show();
                }
                else if (cmbEmployee1.SelectedItem.Equals("service Manager"))
                {
                    String query = "insert Into Employee(Username,EmpType,EmpPassword)" +
                         "VALUES('" + txtuserName.Text + "','" + "serviceManager" + "','" + Hashing.Encrypt(txtpassword.Text) + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Welcome! " + txtuserName.Text + "", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    SignIn objsign = new SignIn();
                    this.Visibility = Visibility.Hidden;
                    objsign.Show();
                }
                else if (cmbEmployee1.SelectedItem.Equals("timesheet Manager"))
                {
                    String query = "insert Into Employee(Username,EmpType,EmpPassword)" +
                        "VALUES('" + txtuserName.Text + "','" + "timeSheetManager" + "','" + Hashing.Encrypt(txtpassword.Text) + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Welcome! " + txtuserName.Text + "", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    SignIn objsign = new SignIn();
                    this.Visibility = Visibility.Hidden;
                    objsign.Show();
                }
                else if (cmbEmployee1.SelectedItem.Equals("Driver"))
                {
                    String query = "insert Into Employee(Username,EmpType,EmpPassword)" +
                         "VALUES('" + txtuserName.Text + "','" + "Driver" + "','" + Hashing.Encrypt(txtpassword.Text) + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Welcome! " + txtuserName.Text + "", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    SignIn objsign = new SignIn();
                    this.Visibility = Visibility.Hidden;
                    objsign.Show();
                }
                else
                {
                    MessageBox.Show("Please Specify The Type Of Employee You Are", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
