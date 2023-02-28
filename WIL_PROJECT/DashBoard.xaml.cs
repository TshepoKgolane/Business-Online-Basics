using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WIL_PROJECT
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        DispatcherTimer timer;

        double panelWidth;
        bool hidden;
        public DashBoard()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0,0,10);
            timer.Tick += Timer_Tick;

            panelWidth = sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden) {

                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth) {

                    timer.Stop();
                    hidden = false;
                }
            
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 45)
                {

                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) {

                DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(3);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            System.Environment.Exit(2);
        
        }

        private void btnVehicle_Click(object sender, RoutedEventArgs e)
        {
            new VehicleStatus().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(3);
            this.Hide();
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {
            new ServiceSheet().Show();
            this.Hide();
        }

        private void btnTrip_Click(object sender, RoutedEventArgs e)
        {
            new TripSheet().Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            new ReportSheet().Show();
            this.Hide();
        }
    }
}
