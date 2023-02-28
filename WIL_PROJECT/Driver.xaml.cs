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
    /// Interaction logic for Driver.xaml
    /// </summary>
    public partial class Driver : Window
    {
        public Driver()
        {
            InitializeComponent();
            cmbVehicleConfig.Items.Add("Bus(9-15 seats)");
            cmbVehicleConfig.Items.Add("Bus(16 or more seats)");
            cmbVehicleConfig.Items.Add("Single-unit(2 axles,6 Tires)");
            cmbVehicleConfig.Items.Add("Single-Unit(3 or more Axles)");
            cmbVehicleConfig.Items.Add("Truck/Trailer(Single-unit Truck pulling a Trailer)");
            cmbVehicleConfig.Items.Add("Truck Tractor(Bobtail)");
            cmbVehicleConfig.Items.Add("Tractor/Semi Trailer(One Trailers)");
            cmbVehicleConfig.Items.Add("Truck Tractor/Double (Two Trailers)");
            cmbVehicleConfig.Items.Add("Truck Tractor/Triple (Three Trailers)");
            //cmbVehicleBodyType items
            cmbVehicleBodyType.Items.Add("Bus(9-15 seats)");
            cmbVehicleBodyType.Items.Add("Bus(16 or more seats)");
            cmbVehicleBodyType.Items.Add("Van/Enclosed Box");
            cmbVehicleBodyType.Items.Add("Cargo Tank");
            cmbVehicleBodyType.Items.Add("Flat Bed");
            cmbVehicleBodyType.Items.Add("Dump Truck");
            cmbVehicleBodyType.Items.Add("Concrete Mixer");
            cmbVehicleBodyType.Items.Add("Auto Transporter");
            cmbVehicleBodyType.Items.Add("Garbage/Refuse");
            cmbVehicleBodyType.Items.Add("Grain,Chip,Gravel");
            cmbVehicleBodyType.Items.Add("Pole");
            cmbVehicleBodyType.Items.Add("Log");
            cmbVehicleBodyType.Items.Add("Intermodal Chassis");
            cmbVehicleBodyType.Items.Add("Vehicle Towing Motor Vehicle");
            cmbVehicleBodyType.Items.Add("No Cargo Body");
            //cmb city
            cmbCity.Items.Add("Johannesburg");
            cmbCity.Items.Add("Pretoria");
            cmbCity.Items.Add("Durban");
            cmbCity.Items.Add("Polokwane");
            cmbCity.Items.Add("Bloemfontein");
            cmbCity.Items.Add("Cape Town");
            cmbCity.Items.Add("Pietermaritzburg");
        }
        public String bodyType;
        public String vehicleConfig;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(SignIn.connString);
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                if (cmbVehicleConfig.SelectedItem.Equals("Bus(9 - 15 seats)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','"+txtLicence+ "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();

                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Bus(16 or more seats)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Single-unit(2 axles,6 Tires)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Single-Unit(3 or more Axles)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Truck/Trailer(Single-unit Truck pulling a Trailer)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Truck Tractor(Bobtail)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Tractor/Semi Trailer(One Trailers)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Truck Tractor/Double (Two Trailers)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleConfig.SelectedItem.Equals("Truck Tractor/Triple (Three Trailers)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Bus(9-15 seats)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Bus(16 or more seats)"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Van/Enclosed Box"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Cargo Tank"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Flat Bed"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Dump Truck"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Concrete Mixer"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Auto Transporter"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Garbage/Refuse"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Grain,Chip,Gravel"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Pole"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Log"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Intermodal Chassis"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("Vehicle Towing Motor Vehicle"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else if (cmbVehicleBodyType.SelectedItem.Equals("No Cargo Body"))
                {
                    String query = "insert Into Driver(employeeNumber,name,surname,licenceNr,city,phoneNumber,Email,VehicleConfig,VehicleBody)" +
                       "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtdriverName.Text + "','" + txtDriverSurname.Text + "','" + txtLicence + "','" + cmbCity.SelectedItem + "','" + txtPhone + "','" + txtEmail + "','" + cmbVehicleConfig.SelectedItem + "','" + cmbVehicleBodyType.SelectedItem + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new VehicleStatus().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please select a value from the combo boxes", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }


        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtdriverName.Clear();
            txtDriverSurname.Clear();
            txtEmail.Clear();
            txtLicence.Clear();
            txtPhone.Clear();

            txtdriverName.Clear();
            txtdriverName.Clear();
            txtdriverName.Clear();
            txtdriverName.Clear();
        }
    }
}
