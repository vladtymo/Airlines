using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FlightService flightService = new FlightService();
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = flightService.GetAllFlights().Select(f => new
            {
                Number = f.Number,
                Time = f.DepartureTime,
                AirplaneModel = f.Airplane.Model,
                From = f.CityFrom.Name,
                To = f.CityTo.Name
            }).ToList();
        }
    }
}
