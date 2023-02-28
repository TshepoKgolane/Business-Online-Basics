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
    /// Interaction logic for VehicleStatus.xaml
    /// </summary>
    public partial class VehicleStatus : Window
    {
        public VehicleStatus()
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
            try
            {
                connection.Open();
                //insert to database here
                String query = "insert Into VehicleStatus(employeeNumber,vehicleNumb,Manufacturer,EngineSize,NextOdometer,VehicleType,OdometerReader)" +
                               "VALUES(" + SignIn.currentemployeeNumber + ",'" + txtvehicleNumber.Text + "','" + txtvehicleManufacturer.Text + "','" + txtengineSize.Text + "','" + txtserviceOdometer.Text + "','" + txtvehicleType.Text + "','" + txtodometerReading.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();

                listVehicle.Items.Add("Vehicle Number");//0
                listVehicle.Items.Add(txtvehicleNumber.Text);
                listVehicle.Items.Add("Registration Number");//2
                listVehicle.Items.Add(txtvehicleManufacturer.Text);
                listVehicle.Items.Add("Engine Size");//4
                listVehicle.Items.Add(txtengineSize.Text);
                listVehicle.Items.Add("Service Odometer");//6
                listVehicle.Items.Add(txtserviceOdometer.Text);
                listVehicle.Items.Add("Vehicle Type");//8
                listVehicle.Items.Add(txtvehicleType.Text);
                listVehicle.Items.Add("Odometer Reading");//10
                listVehicle.Items.Add(txtodometerReading.Text);

                MessageBox.Show("Added vehicle List to database", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Visibility = Visibility.Hidden;
                
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            finally
            {
                connection.Close();
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DashBoard shu = new DashBoard();
            shu.Show();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtengineSize.Clear();
            txtodometerReading.Clear();
            txtregistrationNumber.Clear();
            txtserviceOdometer.Clear();
            txtvehicleManufacturer.Clear();
            txtvehicleNumber.Clear();
            txtvehicleType.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please Enter new value for "+listVehicle.SelectedItem);
            //edit button
            if (listVehicle.SelectedIndex==1)
            {
                listVehicle.Items.Remove(listVehicle.Items[1]);
                listVehicle.Items[1] = txtvehicleNumber.Text;
            }
            else if (listVehicle.SelectedIndex == 3)
            {
                listVehicle.Items.Remove(listVehicle.Items[3]);
                listVehicle.Items[3] = txtvehicleNumber.Text;
            }
            if (listVehicle.SelectedIndex == 5)
            {
                listVehicle.Items.Remove(listVehicle.Items[5]);
                listVehicle.Items[5] = txtvehicleNumber.Text;
            }else if (listVehicle.SelectedIndex == 7)
            {
                listVehicle.Items.Remove(listVehicle.Items[7]);
                listVehicle.Items[7] = txtvehicleNumber.Text;
            }else if (listVehicle.SelectedIndex == 9)
            {
                listVehicle.Items.Remove(listVehicle.Items[9]);
                listVehicle.Items[9] = txtvehicleNumber.Text;
            }else if (listVehicle.SelectedIndex == 11)
            {
                listVehicle.Items.Remove(listVehicle.Items[11]);
                listVehicle.Items[11] = txtvehicleNumber.Text;
            }
            
        }
    }
}
