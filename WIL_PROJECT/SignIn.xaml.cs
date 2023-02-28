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
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
            cmbEmployee.Items.Add("Office Manager");
            cmbEmployee.Items.Add("vehicle Information Manager");
            cmbEmployee.Items.Add("Trip Manager");
            cmbEmployee.Items.Add("service Manager");
            cmbEmployee.Items.Add("timesheet Manager");
            cmbEmployee.Items.Add("Driver");
        }
        public static String connString = @"Data Source=RCBF501PC24\SQLEXPRESS;Initial Catalog=BusinessOnlineBasics;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connString);

        public static string currentemployeeNumber;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                string Username;
                string userPassword;
                string EmpType;
                //ching which type of user is signing up
                if (cmbEmployee.SelectedItem.Equals("Office Manager"))
                {

                    String query = "Select * from Employee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader Reader = command.ExecuteReader();


                    while (Reader.Read())
                    {
                        currentemployeeNumber = Reader["employeeNumber"].ToString();
                        Username = Reader["Username"].ToString();//assigning 
                        userPassword = Reader["EmpPassword"].ToString();
                        EmpType = Reader["EmpType"].ToString();

                        //if email provided is same as email in the database and password provided is same as password in database allow access 
                        if (txtuserName.Text == Username && txtpassword.Text == Hashing.Decrypt(userPassword))
                        {
                            
                            //Display message for successful log in
                            MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                            //go to office manager window here 
                            OfficeManager manag = new OfficeManager();
                            manag.Show();
                            //
                            this.Visibility = Visibility.Hidden;

                        }
                    }
                }
                else if (cmbEmployee.SelectedItem.Equals("vehicle Information Manager"))
                {

                    String query = "Select * from Employee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader Reader = command.ExecuteReader();


                    while (Reader.Read())
                    {
                        currentemployeeNumber = Reader["employeeNumber"].ToString();
                        Username = Reader["Username"].ToString();//assigning 
                        userPassword = Reader["EmpPassword"].ToString();
                        EmpType = Reader["EmpType"].ToString();

                        //if email provided is same as email in the database and password provided is same as password in database allow access 
                        if (txtuserName.Text == Username && txtpassword.Text == Hashing.Decrypt(userPassword))
                        {

                            //Display message for successful log in
                            MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                            //go to vehicleInformationManager window here 
                            VehicleInformationManager vehiclobj = new VehicleInformationManager();
                            vehiclobj.Show();
                            //
                            this.Visibility = Visibility.Hidden;

                        }
                    }
                }
                else if (cmbEmployee.SelectedItem.Equals("Trip Manager"))
                {

                    String query = "Select * from Employee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader Reader = command.ExecuteReader();


                    while (Reader.Read())
                    {
                        currentemployeeNumber = Reader["employeeNumber"].ToString();
                        Username = Reader["Username"].ToString();//assigning 
                        userPassword = Reader["EmpPassword"].ToString();
                        EmpType = Reader["EmpType"].ToString();

                        //if email provided is same as email in the database and password provided is same as password in database allow access 
                        if (txtuserName.Text == Username && txtpassword.Text == Hashing.Decrypt(userPassword))
                        {

                            //Display message for successful log in
                            MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                            //go to Trip Manager window here 
                            TripManager tripM = new TripManager();
                            tripM.Show();
                            //
                            this.Visibility = Visibility.Hidden;

                        }
                    }
                }
                else if (cmbEmployee.SelectedItem.Equals("service Manager"))
                {

                    String query = "Select * from Employee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader Reader = command.ExecuteReader();


                    while (Reader.Read())
                    {
                        currentemployeeNumber = Reader["employeeNumber"].ToString();
                        Username = Reader["Username"].ToString();//assigning 
                        userPassword = Reader["EmpPassword"].ToString();
                        EmpType = Reader["EmpType"].ToString();

                        //if email provided is same as email in the database and password provided is same as password in database allow access 
                        if (txtuserName.Text == Username && txtpassword.Text == Hashing.Decrypt(userPassword))
                        {

                            //Display message for successful log in
                            MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                            //go to service Manager window here 
                            serviceManager serviceM = new serviceManager();
                            serviceM.Show();
                            //
                            this.Visibility = Visibility.Hidden;

                        }
                    }
                }
                
                else if (cmbEmployee.SelectedItem.Equals("timesheet Manager"))
                {

                    String query = "Select * from Employee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader Reader = command.ExecuteReader();


                    while (Reader.Read())
                    {
                        currentemployeeNumber = Reader["employeeNumber"].ToString();
                        Username = Reader["Username"].ToString();//assigning 
                        userPassword = Reader["EmpPassword"].ToString();
                        EmpType = Reader["EmpType"].ToString();

                        //if email provided is same as email in the database and password provided is same as password in database allow access 
                        if (txtuserName.Text == Username && txtpassword.Text == Hashing.Decrypt(userPassword))
                        {

                            //Display message for successful log in
                            MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                            //go to timesheet Manager window here 
                            new DashBoard().Show();
                            //
                            this.Visibility = Visibility.Hidden;

                        }
                    }
                }
                else if (cmbEmployee.SelectedItem.Equals("Driver"))
                {

                    String query = "Select * from Employee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader Reader = command.ExecuteReader();


                    while (Reader.Read())
                    {
                        currentemployeeNumber = Reader["employeeNumber"].ToString();
                        Username = Reader["Username"].ToString();//assigning 
                        userPassword = Reader["EmpPassword"].ToString();
                        EmpType = Reader["EmpType"].ToString();

                        //if email provided is same as email in the database and password provided is same as password in database allow access 
                        if (txtuserName.Text == Username && txtpassword.Text == Hashing.Decrypt(userPassword))
                        {
                            //Display message for successful log in
                            MessageBox.Show("Successfully Logged in " + Username, "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                            //go to Driver window here 
                            Driver dr = new Driver();
                            dr.Show();
                            this.Visibility = Visibility.Hidden;
                        }
                    }
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
            finally
            {
                connection.Close();
            }
        
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(3);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            new SignUpInterface().Show();
        }
    }
}
